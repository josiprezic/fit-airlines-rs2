using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IOffersService
    {
        List<Model.Offers> Get(Model.Requests.OffersSearchRequest request);
        Model.Offers GetById(int id);

        Model.Offers Insert(Model.Requests.OffersInsertRequest request);
        Model.Offers Update(int id, Model.Requests.OffersInsertRequest request);
    }
}
