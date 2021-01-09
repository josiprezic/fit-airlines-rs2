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

        public FlightsService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

            if (request.CountryId != null)
            {
                query = query.Where(x => x.City.CountryId == request.CountryId);
            }

            if (request.AvailableToMemberTypeId != null)
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
                            CountryName = x.City.Country.CountryName
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
                    }
                })
                .ToList();
            return _mapper.Map<List<Model.Flights>>(list);
        }

        public Model.Flights GetById(int id)
        {
            var entity = _context.Flights
                .Where(x => x.FlightId == id)
                .Include(x => x.Offer)
                .Include(x => x.City.Country)
                .Include(x => x.AvailableToMemberType)
                .Include(x => x.Plane)
                .FirstOrDefault();
            return _mapper.Map<Model.Flights>(entity);
        }

        public Model.Flights Insert(FlightsInsertRequest request)
        {
            var entity = _mapper.Map<Database.Flights>(request);

            entity.AddedDate = DateTime.Now;
            // TODO: JR // TODO: Szef remove hardcoded value. UserId should be send though the insert request probably?
            // Nie, trzeba login zrobić
            entity.AddedByUserId = 1;
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
