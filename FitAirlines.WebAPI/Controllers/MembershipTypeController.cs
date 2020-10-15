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
    public class MembershipTypesController : ControllerBase
    {
        private readonly IMembershipTypesService _service;

        public MembershipTypesController(IMembershipTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.MembershipTypes> Get() 
        {
            return _service.Get();   
        }
    }
}