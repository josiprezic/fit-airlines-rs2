using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Offers
    {
        public Offers()
        {
            Flights = new HashSet<Flights>();
        }

        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateAdded { get; set; }
        public int OfferTypeId { get; set; }

        public OfferTypes OfferType { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}
