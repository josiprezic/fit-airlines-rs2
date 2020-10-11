using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public int ReservationId { get; set; }
        public double RatingValue { get; set; }
        public string Notes { get; set; }
        public DateTime? DateAdded { get; set; }

        public Reservations Reservation { get; set; }
    }
}
