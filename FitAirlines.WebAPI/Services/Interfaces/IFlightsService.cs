using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IFlightsService
    {
        List<Model.Flights> Get(Model.Requests.FlightsSearchRequest request);
        Model.Flights GetById(int id);

        Model.Flights Insert(Model.Requests.FlightsInsertRequest request);
        Model.Flights Update(int id, Model.Requests.FlightsInsertRequest request);
    }
}
