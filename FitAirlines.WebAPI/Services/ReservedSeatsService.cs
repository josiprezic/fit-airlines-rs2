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
    public class ReservedSeatsService : IReservedSeatsService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public ReservedSeatsService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.ReservedSeats> Get(ReservedSeatsSearchRequest request)
        {
            var query = _context.ReservedSeats.AsQueryable();

            if (request.FlightId != 0)
            {
                query = query.Where(x => x.Reservation.FlightId == request.FlightId);
            }

            return _mapper.Map<List<Model.ReservedSeats>>(query.ToList());
        }

    }
}
