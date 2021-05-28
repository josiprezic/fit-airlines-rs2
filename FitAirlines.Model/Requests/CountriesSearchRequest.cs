using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class CountriesSearchRequest
    {
        public bool HideCountriesWithNoCities { get; set; }
    }
}
