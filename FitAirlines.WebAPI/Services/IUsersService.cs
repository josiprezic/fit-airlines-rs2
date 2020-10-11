﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IUsersService
    {
        List<Model.Users> Get();
        Model.Users GetById(int id);

        Model.Users Insert(Model.Requests.UsersInsertRequest request);



    }
}
