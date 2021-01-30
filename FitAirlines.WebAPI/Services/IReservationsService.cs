using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IReservationsService
    {
        List<Model.Reservations> Get(Model.Requests.ReservationsSearchRequest request);
        Model.Reservations GetById(int id);
        Model.Reservations Insert(Model.Requests.ReservationsInsertRequest request);
        Model.Reservations Update(int id, Model.Requests.ReservationsInsertRequest request);
    }
}
