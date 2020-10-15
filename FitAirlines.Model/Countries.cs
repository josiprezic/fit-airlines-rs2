using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Countries
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
    }
}
