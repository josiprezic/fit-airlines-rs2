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
    public class ReservedSeatsController : ControllerBase
    {
        private readonly IReservedSeatsService _service;

        public ReservedSeatsController(IReservedSeatsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.ReservedSeats> Get([FromQuery] Model.Requests.ReservedSeatsSearchRequest request) 
        {
            return _service.Get(request);
        }
    }
}