using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Cities
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        public int CountryId { get; set; }

        public Countries Country { get; set; }
    }
}
