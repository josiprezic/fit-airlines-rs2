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
    public class OffersController : ControllerBase
    {
        private readonly IOffersService _service;

        public OffersController(IOffersService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Offers> Get([FromQuery] Model.Requests.OffersSearchRequest request) 
        {
            return _service.Get(request);   
        }

        [HttpGet("{Id}")]
        public Model.Offers GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Offers Insert([FromBody] Model.Requests.OffersInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{Id}")]
        public Model.Offers Update(int Id, [FromBody] Model.Requests.OffersInsertRequest request)
        {
            return _service.Update(Id, request);
        }
    }
}