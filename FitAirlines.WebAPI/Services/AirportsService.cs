using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class AirportsService: IAirportsService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public AirportsService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Airports> Get()
        {
            var query = _context.Airports.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Airports>>(list);
        }
    }
}
