using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Planes
    {
        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public int Capacity { get; set; }
        public int NumberOfColumns { get; set; }
        public bool? IsAvailable { get; set; }
    }
}
