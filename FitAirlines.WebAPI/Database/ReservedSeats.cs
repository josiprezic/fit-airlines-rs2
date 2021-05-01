using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class ReservedSeats
    {
        public int ReservedSeatId { get; set; }
        public int ReservationId { get; set; }
        public string Direction { get; set; }
        public double SeatPrice { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }

        public string Seat => SeatRow.ToString() + (char)(64 + (char)SeatColumn);

        public Reservations Reservation { get; set; }
    }
}
