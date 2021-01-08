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
    public class PlanesController : ControllerBase
    {
        private readonly IPlanesService _service;

        public PlanesController(IPlanesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Planes> Get() 
        {
            return _service.Get();   
        }
    }
}
