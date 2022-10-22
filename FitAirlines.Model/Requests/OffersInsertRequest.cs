
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class OffersInsertRequest
    {


        [Required]
        public string OfferName { get; set; }

        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [Required]
        public int OfferTypeId { get; set; }


    }
}
