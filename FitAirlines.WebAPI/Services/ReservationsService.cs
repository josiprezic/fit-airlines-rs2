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
        private readonly IUsersService _usersService;

        public ReservationsService(FitAirlinesContext context, IMapper mapper, IUsersService usersService)
        {
            _context = context;
            _mapper = mapper;
            _usersService = usersService;
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
            if (request.FlightId != 0)
            {
                query = query.Where(x => x.FlightId == request.FlightId);
            }

            var list = ExtractReservationData(query)
                .OrderByDescending(x => x.ReservationDate)
                .ToList();
            return list;
        }

        public Model.Reservations GetById(int id)
        {
            var entity = ExtractReservationData(_context.Reservations
                .Where(x => x.ReservationId == id))
                .FirstOrDefault();
            return _mapper.Map<Model.Reservations>(entity);
        }

        private IQueryable<Model.Reservations> ExtractReservationData(IQueryable<Reservations> query)
        {
            return query
                .Select(x => new Model.Reservations
                {
                    ReservationId = x.ReservationId,
                    BaseTicketPrice = x.BaseTicketPrice,
                    IsValid = x.IsValid,
                    FlightId = x.FlightId,
                    Notes = x.Notes,
                    Flight = new Model.Flights
                    {
                        City = new Model.Cities
                        {
                            CityName = x.Flight.City.CityName,
                            Country = new Model.Countries
                            {
                                CountryName = x.Flight.City.Country.CountryName
                            }
                        },
                        OfferId = x.Flight.OfferId,
                        Offer = new Model.Offers
                        {
                            OfferName = x.Flight.Offer.OfferName
                        },
                        StartDate = x.Flight.StartDate,
                        EndDate = x.Flight.EndDate,
                        Price = x.Flight.Price,
                    },
                    CashierId = x.CashierId,
                    Cashier = new Model.Users
                    {
                        FirstName = x.Cashier.FirstName,
                        LastName = x.Cashier.LastName
                    },
                    //Ratings = _mapper.Map<List<Model.Ratings>>(x.Ratings),
                    ReservationDate = x.ReservationDate,
                    TotalDiscountPercentage = x.TotalDiscountPercentage,
                    UserId = x.UserId,
                    User = new Model.Users
                    {
                        FirstName = x.User.FirstName,
                        LastName = x.User.LastName,
                        MembershipType = new Model.MembershipTypes
                        {
                            Title = x.User.MembershipType.Title
                        }
                    },//x.User
                    SeatDeparture = x.ReservedSeats.Where(y => y.Direction == "1").FirstOrDefault().SeatName ?? "-",
                    SeatReturn = x.ReservedSeats.Where(y => y.Direction == "2").FirstOrDefault().SeatName ?? "-"
                });
        }

        public Model.Reservations Insert(ReservationsInsertRequest request)
        {
            var entity = _mapper.Map<Database.Reservations>(request);
            if(_usersService.CurrentUser.UserRole.Title != "FIT Member")
                entity.CashierId = _usersService.CurrentUser.UserId;
            entity.ReservationDate = DateTime.Now;

            var flight = _context.Flights.Find(request.FlightId);
            entity.BaseTicketPrice = flight.Price;

            _context.Reservations.Add(entity);

            // Add Departure Seat
            entity.ReservedSeats.Add(new ReservedSeats
            {
                Direction = "1",
                SeatIndex = request.SeatIndexDeparture,
                SeatPrice = 0
            });
            // Add Return Seat
            entity.ReservedSeats.Add(new ReservedSeats
            {
                Direction = "2",
                SeatIndex = request.SeatIndexReturn,
                SeatPrice = 0
            });

            _context.SaveChanges();
            return _mapper.Map<Model.Reservations>(entity);
        }

        public Model.Reservations Update(int id, ReservationsUpdateRequest request)
        {
            var entity = _context.Reservations
                .Where(x => x.ReservationId == id)
                .Include(x => x.ReservedSeats)
                .FirstOrDefault();
            if (entity == null)
                return null;

            _context.Reservations.Attach(entity);
            _context.Reservations.Update(entity);
            _mapper.Map(request, entity);

            var seatDeparture = entity.ReservedSeats.FirstOrDefault(x => x.Direction == "1");
            if (seatDeparture != null)
            {
                seatDeparture.SeatIndex = request.SeatIndexDeparture;
            }
            else
            {
                entity.ReservedSeats.Add(new ReservedSeats
                {
                    Direction = "1",
                    SeatIndex = request.SeatIndexDeparture
                });
            }

            var seatReturn = entity.ReservedSeats.FirstOrDefault(x => x.Direction == "2");
            if (seatReturn != null)
            {
                seatReturn.SeatIndex = request.SeatIndexReturn;
            }
            else
            {
                entity.ReservedSeats.Add(new ReservedSeats
                {
                    Direction = "2",
                    SeatIndex = request.SeatIndexReturn
                });
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Reservations>(entity);
        }
    }
}
