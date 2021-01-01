using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class OffersSearchRequest
    {
        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public bool ShowOnlyActive { get; set; }
    }
}
