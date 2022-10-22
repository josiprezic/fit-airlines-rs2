using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Cities
    {
        public Cities()
        {
            Airports = new HashSet<Airports>();
            Flights = new HashSet<Flights>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        public int CountryId { get; set; }

        public Countries Country { get; set; }
        public ICollection<Airports> Airports { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}
