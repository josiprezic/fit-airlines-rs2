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
    public class ReservationsService : IReservationsService
    {
        private readonly FitAirlinesContext _context;
        
        private readonly IMapper _mapper;

        public ReservationsService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Reservations> Get(ReservationsSearchRequest request)
        {
            var query = _context.Reservations.AsQueryable();
            if (!string.IsNullOrEmpty(request.UserName)) 
            {
                query = query.Where(x => (x.User.FirstName + " " + x.User.LastName).Contains(request.UserName));
            }

            if (!string.IsNullOrEmpty(request.FlightName))
            {
                query = query.Where(x => (x.Flight.City.CityName + " " + x.Flight.City.Country.CountryName).Contains(request.FlightName));
            }

            if (request.ReservationDate != null)
            {
                query = query.Where(x => x.ReservationDate.DayOfYear == request.ReservationDate.Value.DayOfYear && request.ReservationDate.Value.Year == x.ReservationDate.Year);
            }

            if (request.ShowOnlyActive)
            {
                query = query.Where(x => x.IsValid == true);
            }

            var list = query
                //.Include(x => x.OfferType)
                .Select(x=>new Reservations
                {
                    ReservationId = x.ReservationId,
                    BaseTicketPrice = x.BaseTicketPrice,
                    IsValid = x.IsValid,
                    FlightId = x.FlightId,
                    Notes = x.Notes,
                    Flight = new Flights
                    { 
                        City = new Cities { 
                            CityName = x.Flight.City.CityName,
                            Country = new Countries
                            {
                                CountryName = x.Flight.City.Country.CountryName
                            }
                        },
                    },

                    CashierId = x.CashierId,
                    Ratings = x.Ratings,
                    ReservationDate = x.ReservationDate,
                    TotalDiscountPercentage = x.TotalDiscountPercentage,
                    UserId = x.UserId,
                    User = new Users { 
                        FirstName = x.User.FirstName,
                        LastName = x.User.LastName
                    }//x.User
                })
                .ToList();
            return _mapper.Map<List<Model.Reservations>>(list);
        }

        public Model.Reservations GetById(int id)
        {
            var entity = _context.Reservations
                .Where(x => x.ReservationId == id)
                //.Include(x => x.OfferType)
                .FirstOrDefault();
            return _mapper.Map<Model.Reservations>(entity);
        }

        public Model.Reservations Insert(ReservationsInsertRequest request)
        {
            var entity = _mapper.Map<Database.Reservations>(request);
            //entity.DateAdded = DateTime.Now;
            entity.CashierId = 1; // TODO: Szef this should be equal to currently logged in user ID
            entity.ReservationDate = DateTime.Now;

            _context.Reservations.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Reservations>(entity);
        }

        public Model.Reservations Update(int id, ReservationsInsertRequest request)
        {
            var entity = _context.Reservations.Find(id);
            _context.Reservations.Attach(entity);
            _context.Reservations.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Reservations>(entity);
        }
    }
}
