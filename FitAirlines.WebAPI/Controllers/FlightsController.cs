using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitAirlines.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitAirlines.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightsService _service;

        public FlightsController(IFlightsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Flights> Get([FromQuery] Model.Requests.FlightsSearchRequest request) 
        {
            return _service.Get(request);   
        }

        [HttpGet("GetRecommendedFlights")]
        [Authorize]
        public List<Model.Flights> GetRecommendedFlights() 
        {
            return _service.GetRecommendedFlights();   
        }

        [HttpGet("{Id}")]
        public Model.Flights GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Flights Insert([FromBody] Model.Requests.FlightsInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{Id}")]
        public Model.Flights Update(int Id, [FromBody] Model.Requests.FlightsInsertRequest request)
        {
            return _service.Update(Id, request);
        }
    }
}