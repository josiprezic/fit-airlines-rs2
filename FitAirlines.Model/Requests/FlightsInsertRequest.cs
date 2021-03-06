﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class FlightsInsertRequest
    {
        [Required]
        public int CityId { get; set; }

        [Required]
        public int DestinationAirportId { get; set; }

        [Required] 
        public int OfferId { get; set; }

        [Required]
        public int PlaneId { get; set; }

        //[Required]
        public string VoucherCode { get; set; }

        //[Required]
        public double? VoucherDiscountPercentage { get; set; }
       
        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }
        
        [Required]
        public string PilotFullName { get; set; }
        
        [Required]
        public TimeSpan FlightDuration { get; set; }
        
        [Required]
        public double Price { get; set; }

        //[Required]
        public string ShortInfo { get; set; }

        //[Required]
        public byte[] Picture { get; set; }

        //[Required]
        public string Notes { get; set; }

        [Required]
        public int AvailableToMemberTypeId { get; set; }
        
        [Required]
        public bool? IsActive { get; set; }
        
    }
}
