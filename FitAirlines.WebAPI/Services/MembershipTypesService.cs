using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class MembershipTypesService: IMembershipTypesService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public MembershipTypesService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.MembershipTypes> Get()
        {
            var query = _context.MembershipTypes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.MembershipTypes>>(list);
        }
    }
}
