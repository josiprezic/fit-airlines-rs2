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
    public class OfferTypesController : ControllerBase
    {
        private readonly IOfferTypesService _service;

        public OfferTypesController(IOfferTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.OfferTypes> Get() 
        {
            return _service.Get();   
        }
    }
}