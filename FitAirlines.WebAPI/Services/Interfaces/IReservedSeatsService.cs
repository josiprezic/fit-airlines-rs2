using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IReservedSeatsService
    {
        List<Model.ReservedSeats> Get(Model.Requests.ReservedSeatsSearchRequest request);
    }
}
