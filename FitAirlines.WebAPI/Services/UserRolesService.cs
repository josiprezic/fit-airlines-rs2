using AutoMapper;
using FitAirlines.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class UserRolesService : IUserRolesService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public UserRolesService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.UserRoles> Get()
        {
            var query = _context.UserRoles.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.UserRoles>>(list);
        }
    }
}
