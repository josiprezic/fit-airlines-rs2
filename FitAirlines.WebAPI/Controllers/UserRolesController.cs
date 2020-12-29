using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitAirlines.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitAirlines.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRolesService _service;

        public UserRolesController(IUserRolesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.UserRoles> Get() 
        {
            return _service.Get();   
        }
    }
}