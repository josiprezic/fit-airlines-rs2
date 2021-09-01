using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitAirlines.WebAPI.Services;
using FitAirlines.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitAirlines.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingsService _service;

        public RatingsController(IRatingsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Ratings> Get([FromQuery] Model.Requests.RatingsSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost("RateFlight")]
        public Model.Ratings RateFlight([FromBody] Model.Requests.RatingsInsertRequest request)
        {
            return _service.RateFlight(request);
        }
    }
}