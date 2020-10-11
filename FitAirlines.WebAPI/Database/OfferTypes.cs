using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class OfferTypes
    {
        public OfferTypes()
        {
            Offers = new HashSet<Offers>();
        }

        public int OfferTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }

        public ICollection<Offers> Offers { get; set; }
    }
}
