using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Countries
    {
        public Countries()
        {
            Cities = new HashSet<Cities>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Cities> Cities { get; set; }
    }
}
