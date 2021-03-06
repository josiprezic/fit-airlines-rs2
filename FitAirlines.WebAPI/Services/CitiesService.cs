﻿using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class CitiesService: ICitiesService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public CitiesService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Cities> Get()
        {
            var query = _context.Cities.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Cities>>(list);
        }
    }
}
