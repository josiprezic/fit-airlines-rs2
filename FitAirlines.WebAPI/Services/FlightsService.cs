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
                query = query.Where(x => x.StartDate == request.StartDate);
            }


            if (request.EndDate!= null)
            {
                query = query.Where(x => x.EndDate == request.EndDate);
            }

            if (request.CityId != null)
            {
                query = query.Where(x => x.CityId == request.CityId);
            }

            if (request.CountryId != null)
            {
                query = query.Where(x => x.City.CountryId == request.CountryId);
            }

            //if (request.EndDate != null)
            //{
            //    query = query.Where(x => ((x.EndDate.Day == request.EndDate?.Day) && (x.EndDate.Month == request.EndDate?.Month) && (x.EndDate.Year == request.EndDate.Year)));
            //}



            if (request.IsActive ?? false) // TODO: JR // TODO: Szef "false" or true here?
            {
                query = query.Where(x => x.IsActive == true);
            }

            

            var list = query

                //             .Where(x => x.CityId == request.CityId)
                //              .Where(x => x.OfferId == request.OfferId)
                //                .Where(x => x.AvailableToMemberTypeId == request.AvailableToMemberTypeId)

                .Include(x => x.Offer.OfferName) // TODO: Szef I have picture bytes[] in response, I don't want it. I just want the offer name.
                .Include(x => x.City)
                .Include(x => x.City.Country) // TODO: Szef country = null in response body ;(
                
                .Include(x => x.AvailableToMemberType)
                .Include(x => x.Plane)
                .Select(x=>new Flights
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
                    City = x.City,
                    AvailableToMemberType = x.AvailableToMemberType,
                    VoucherCode = x.VoucherCode,
                    VoucherDiscountPercentage = x.VoucherDiscountPercentage,
                    AvailableToMemberTypeId = x.AvailableToMemberTypeId,
                    AddedByUserId = x.AddedByUserId, 
                    Plane = x.Plane,
                   // Offer = x.Offer
                })
                .ToList();
            return _mapper.Map<List<Model.Flights>>(list);// TODO: JR probably mapper will not be able to map missing values here [?].
        }

        public Model.Flights GetById(int id)
        {
            var entity = _context.Flights
                .Where(x => x.FlightId == id)
                //.Include(x => x.FlightType)
                .FirstOrDefault();
            return _mapper.Map<Model.Flights>(entity);
        }

        public Model.Flights Insert(FlightsInsertRequest request)
        {
            var entity = _mapper.Map<Database.Flights>(request);
           
            entity.AddedDate = DateTime.Now;
            // TODO: JR // TODO: Szef remove hardcoded value. UserId should be send though the insert request probably?
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
