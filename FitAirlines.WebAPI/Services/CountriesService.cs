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

        public List<Model.Countries> Get(Model.Requests.CountriesSearchRequest request)
        {
            var query = _context.Countries.AsQueryable();
            if(request.HideCountriesWithNoCities)
            {
                query = query.Where(x => x.Cities.Any());
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Countries>>(list);
        }
    }
}
