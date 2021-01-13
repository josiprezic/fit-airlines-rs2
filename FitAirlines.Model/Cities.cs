using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Cities: IComparable
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        public int CountryId { get; set; }

        public Countries Country { get; set; }

        public override string ToString()
        {
            return CityName;
        }

        public int CompareTo(object obj)
        {
            var otherCity = obj as Cities;
            return this.CityName.CompareTo(otherCity.CityName);
        }
    }
}
