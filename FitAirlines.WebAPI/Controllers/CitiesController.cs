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
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesService _service;

        public CitiesController(ICitiesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Cities> Get() 
        {
            return _service.Get();   
        }
    }
}