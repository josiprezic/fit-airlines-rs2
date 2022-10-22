using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Countries: IComparable
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }

        public int CompareTo(object obj)
        {
            var otherCountry = obj as Countries;
            //return otherCountry.CountryName.CompareTo(this.CountryName);
            return this.CountryName.CompareTo(otherCountry.CountryName);
        }
    }
}
