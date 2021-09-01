using AutoMapper;
using FitAirlines.Model.Requests;
using FitAirlines.WebAPI.Database;
using FitAirlines.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FitAirlines.WebAPI.Services
{
    public class FlightsService : IFlightsService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;
        private readonly IUsersService _usersService;

        public FlightsService(FitAirlinesContext context, IMapper mapper, IUsersService usersService)
        {
            _context = context;
            _mapper = mapper;
            _usersService = usersService;
        }

        public List<Model.Flights> Get(FlightsSearchRequest request)
        {
            var query = _context.Flights.AsQueryable();

            if (request.StartDate != null)
            {
                query = query.Where(x =>
                x.StartDate.DayOfYear == request.StartDate.Value.DayOfYear &&
                x.StartDate.Year == request.StartDate.Value.Year
                );
            }

            if (request.EndDate != null)
            {
                query = query.Where(x =>
                x.EndDate.DayOfYear == request.EndDate.Value.DayOfYear &&
                x.EndDate.Year == request.EndDate.Value.Year
                );
            }

            if (request.CityId != null)
            {
                query = query.Where(x => x.CityId == request.CityId);
            }

            if (!string.IsNullOrEmpty(request.CityName))
            {
                query = query.Where(x => x.City.CityName.ToLower().Contains(request.CityName.ToLower()));
            }

            if (request.CountryId != null)
            {
                query = query.Where(x => x.City.CountryId == request.CountryId);
            }

            if(_usersService.CurrentUser.UserRole.Title == "FIT Member")
            {
                query = query.Where(x => x.AvailableToMemberType.MembershipPrice <= _usersService.CurrentUser.MembershipType.MembershipPrice);
            }
            else if (request.AvailableToMemberTypeId != null)
            {
                var SelectedMembershipType = _context.MembershipTypes.Find(request.AvailableToMemberTypeId);
                if (SelectedMembershipType != null)
                {
                    query = query.Where(x => x.AvailableToMemberType.MembershipPrice <= SelectedMembershipType.MembershipPrice);
                }

            }

            if (request.OfferId != null)
            {
                query = query.Where(x => x.OfferId == request.OfferId);
            }


            if (request.IsActive != null)
            {
                query = query.Where(x => x.IsActive == request.IsActive);
            }

            var list = query
                .Select(x => new Flights
                {
                    FlightId = x.FlightId,
                    CityId = x.CityId,
                    OfferId = x.OfferId,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    IsActive = x.IsActive,
                    ShortInfo = x.ShortInfo,
                    Price = x.Price,
                    Notes = x.Notes,
                    FlightDuration = x.FlightDuration,
                    PilotFullName = x.PilotFullName,
                    City = new Cities
                    {
                        CityName = x.City.CityName,
                        Country = new Countries
                        {
                            CountryId = x.City.Country.CountryId,
                            CountryName = x.City.Country.CountryName,
                        }
                    },
                    AvailableToMemberType = x.AvailableToMemberType,
                    VoucherCode = x.VoucherCode,
                    VoucherDiscountPercentage = x.VoucherDiscountPercentage,
                    AvailableToMemberTypeId = x.AvailableToMemberTypeId,
                    AddedByUserId = x.AddedByUserId,
                    Plane = x.Plane,
                    Offer = new Offers
                    {
                        OfferName = x.Offer.OfferName
                    },
                    DestinationAirportId = x.DestinationAirportId,
                    Picture = request.LoadPictures ? x.Picture : new byte[0]
                });

            if(request.FlightsFilter == FlightsFilter.NextFlights)
            {
                list = list.Where(x => x.StartDate.Date >= DateTime.Today)
                           .OrderBy(x => x.StartDate);
            }
            else if(request.FlightsFilter == FlightsFilter.TopOffers)
            {
                list = list.OrderByDescending(x => _context.Reservations.Count(y=>y.FlightId == x.FlightId && y.IsValid.Value));
            }
                
            return _mapper.Map<List<Model.Flights>>(list.ToList());
        }

        public Model.Flights GetById(int id)
        {
            var entity = _context.Flights
                .Where(x => x.FlightId == id)
                .Include(x => x.Offer)
                .Include(x => x.City.Country)
                .Include(x => x.AvailableToMemberType)
                .Include(x => x.Plane)
                .Include(x => x.DestinationAirport)
                .FirstOrDefault();

            var mappedEntity = _mapper.Map<Model.Flights>(entity);

            mappedEntity.AvailableSeats = mappedEntity.Capacity - _context.Reservations.Count(x => x.FlightId == id);
            mappedEntity.AverageRating = _context.Ratings.Where(x => x.Reservation.FlightId == id).Average(a => (double?)a.RatingValue) ?? 5;
            
            return mappedEntity;
        }

        public Model.Flights Insert(FlightsInsertRequest request)
        {
            var entity = _mapper.Map<Database.Flights>(request);

            entity.AddedDate = DateTime.Now;
            entity.AddedByUserId = _usersService.CurrentUser.UserId;
            _context.Flights.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Flights>(entity);
        }

        public Model.Flights Update(int id, FlightsInsertRequest request)
        {
            var entity = _context.Flights.Find(id);

            byte[] OldPicture = entity.Picture;
            if (request.Picture == null || request.Picture.Length == 0)
                request.Picture = OldPicture;

            _context.Flights.Attach(entity);
            _context.Flights.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Flights>(entity);
        }

    }
}
