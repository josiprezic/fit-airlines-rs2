using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class FlightsSearchRequest
    {
        public int? CountryId { get; set; }

        public int? CityId { get; set; }

        public int? OfferId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? IsActive { get; set; }

        public int? AvailableToMemberTypeId { get; set; }
        public string CityName { get; set; }
        public bool LoadPictures { get; set; }

        public FlightsFilter FlightsFilter { get; set; }
    }


    public enum FlightsFilter
    {
        TopOffers,
        NextFlights
    }
}
