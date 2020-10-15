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
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Users> Get() 
        {
            return _service.Get();   
        }

        [HttpGet("{Id}")]
        public Model.Users GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Users Insert([FromBody] Model.Requests.UsersInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{Id}")]
        public Model.Users Update(int Id, [FromBody] Model.Requests.UsersUpdateRequest request)
        {
            return _service.Update(Id, request);
        }
    }
}