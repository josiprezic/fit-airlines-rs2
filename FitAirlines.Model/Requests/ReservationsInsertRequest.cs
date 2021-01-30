using System;
using System.ComponentModel.DataAnnotations;

namespace FitAirlines.Model.Requests
{
    public class ReservationsInsertRequest
    {
        [Required] 
        public string UserId { get; set; }
        
        [Required] 
        public string FlightId { get; set; }
        
        [Required] 
        public DateTime ReservationDate { get; set; }

        [Required]
        public bool? IsActive { get; set; }

        // CashierID // TODO: Szef = This should be equal to current (logged in) user ID (can be null if user bought the ticket by himself through the app)
        // BaseTicketPrice = flight price
        // TotalDiscountPercentage = 0 for now, should be calculated depending on the user membership type

        public string Notes { get; set; }
        
    }
}
