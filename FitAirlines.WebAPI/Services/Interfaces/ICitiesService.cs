﻿using FitAirlines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface ICitiesService
    {
        List<Cities> Get();
    }
}
