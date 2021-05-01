using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class ReservedSeats
    {
        public int ReservedSeatId { get; set; }
        public int ReservationId { get; set; }
        public string Direction { get; set; }
        public double SeatPrice { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }

        public Reservations Reservation { get; set; }
    }
}
