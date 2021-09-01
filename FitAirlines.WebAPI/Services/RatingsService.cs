using System;
using System.Collections.Generic;
using System.Linq;
using FitAirlines.Model;
using FitAirlines.Model.Requests;
using FitAirlines.WebAPI.Database;
using System.Threading.Tasks;
using AutoMapper;
using FitAirlines.WebAPI.Exceptions;
using FitAirlines.WebAPI.Services.Interfaces;

namespace FitAirlines.WebAPI.Services
{
    public class RatingsService: IRatingsService
    {
        private readonly FitAirlinesContext _context;
        private readonly IMapper _mapper;
        private readonly IUsersService _usersService;

        public RatingsService(FitAirlinesContext context, IMapper mapper, IUsersService usersService)
        {
            _context = context;
            _mapper = mapper;
            _usersService = usersService;
        }

        public List<Model.Ratings> Get(RatingsSearchRequest request)
        {
            var query = _context.Ratings.AsQueryable();

            if (request?.FlightId != 0)
                query = query.Where(x => x.Reservation.FlightId == request.FlightId);

            query = query.Where(x => x.Reservation.UserId == _usersService.CurrentUser.UserId);

            var list = query.ToList();

            return _mapper.Map<List<Model.Ratings>>(list);
        }


        public Model.Ratings RateFlight(RatingsInsertRequest request)
        {
            int UserId = _usersService.CurrentUser.UserId;

            Database.Reservations reservation = _context.Reservations.Where(x => x.UserId == UserId && x.FlightId == request.FlightId).FirstOrDefault();
            if(reservation == null)
            {
                throw new UserException("You cannot rate flights you didn't attend.");
            }

            Database.Ratings entity = _context.Ratings.Where(x => x.ReservationId == reservation.ReservationId).FirstOrDefault();
            if (entity != null)
            {
                entity.RatingValue = request.Rating;
            }
            else
            {
                entity = new Database.Ratings
                {
                    ReservationId = reservation.ReservationId,
                    RatingValue = request.Rating,
                    DateAdded = DateTime.Now
                };

                _context.Ratings.Add(entity);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Ratings>(entity);
        }
    }
}
