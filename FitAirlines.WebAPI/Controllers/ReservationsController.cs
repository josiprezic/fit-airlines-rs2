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
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationsService _service;

        public ReservationsController(IReservationsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Reservations> Get([FromQuery] Model.Requests.ReservationsSearchRequest request) 
        {
            return _service.Get(request);   
        }

        [HttpGet("{Id}")]
        public Model.Reservations GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        [Authorize]
        public Model.Reservations Insert([FromBody] Model.Requests.ReservationsInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{Id}")]
        [Authorize]
        public Model.Reservations Update(int Id, [FromBody] Model.Requests.ReservationsUpdateRequest request)
        {
            return _service.Update(Id, request);
        }
    }
}