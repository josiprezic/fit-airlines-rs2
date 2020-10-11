using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Reservations
    {
        public Reservations()
        {
            Ratings = new HashSet<Ratings>();
            ReservedSeats = new HashSet<ReservedSeats>();
        }

        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public DateTime ReservationDate { get; set; }
        public double BaseTicketPrice { get; set; }
        public double TotalDiscountPercentage { get; set; }
        public bool? IsValid { get; set; }
        public int? CashierId { get; set; }
        public string Notes { get; set; }

        public Users Cashier { get; set; }
        public Flights Flight { get; set; }
        public Users User { get; set; }
        public ICollection<Ratings> Ratings { get; set; }
        public ICollection<ReservedSeats> ReservedSeats { get; set; }
    }
}
