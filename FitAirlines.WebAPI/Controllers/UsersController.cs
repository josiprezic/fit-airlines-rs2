﻿using System;
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
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Users> Get([FromQuery] Model.Requests.UsersSearchRequest request) 
        {
            return _service.Get(request);   
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

        [HttpPut("UpdatePassword/{id}")]
        [Authorize]
        public bool UpdatePassword([FromBody] Model.Requests.UsersUpdatePasswordRequest request)
        {
            return _service.UpdatePassword(request);
        }

        [HttpGet("MyProfile")]
        [Authorize]
        public Model.Users MyProfile()
        {
            return _service.MyProfile();
        }
    }
}