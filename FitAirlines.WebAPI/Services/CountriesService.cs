using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class CountriesService: ICountriesService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public CountriesService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Countries> Get()
        {
            var query = _context.Countries.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Countries>>(list);
        }
    }
}
