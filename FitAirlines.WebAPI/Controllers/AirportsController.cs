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
    public class AirportsController : ControllerBase
    {
        private readonly IAirportsService _service;

        public AirportsController(IAirportsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Airports> Get() 
        {
            return _service.Get();   
        }
    }
}