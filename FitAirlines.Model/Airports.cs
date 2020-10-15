using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Airports
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public bool? IsAvailable { get; set; }
        public int CityId { get; set; }

        public Cities City { get; set; }
    }
}
