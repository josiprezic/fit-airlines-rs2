using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Airports
    {
        public Airports()
        {
            Flights = new HashSet<Flights>();
        }

        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public bool? IsAvailable { get; set; }
        public int CityId { get; set; }

        public Cities City { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}
