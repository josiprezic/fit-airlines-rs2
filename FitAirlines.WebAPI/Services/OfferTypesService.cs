using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class OfferTypesService: IOfferTypesService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public OfferTypesService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.OfferTypes> Get()
        {
            var query = _context.OfferTypes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.OfferTypes>>(list);
        }
    }
}
