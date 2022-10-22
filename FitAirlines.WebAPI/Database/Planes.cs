using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Planes
    {
        public Planes()
        {
            Flights = new HashSet<Flights>();
        }

        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public int Capacity { get; set; }
        public int NumberOfColumns { get; set; }
        public bool? IsAvailable { get; set; }

        public ICollection<Flights> Flights { get; set; }
    }
}
