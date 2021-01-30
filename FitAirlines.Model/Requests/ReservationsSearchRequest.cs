using System;

namespace FitAirlines.Model.Requests
{
    public class ReservationsSearchRequest
    {
        public string UserName { get; set; }

        public string FlightName { get; set; }

        public DateTime? ReservationDate { get; set; }

        public bool ShowOnlyActive { get; set; }
    }
}
