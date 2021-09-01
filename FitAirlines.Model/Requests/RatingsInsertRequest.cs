using System;
using System.Collections.Generic;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class RatingsInsertRequest
    {
        public int FlightId { get; set; }
        public int Rating { get; set; }
    }
}
