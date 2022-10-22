using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class ReservedSeats
    {
        public static int NumberOfColumns = 6;

        public int ReservedSeatId { get; set; }
        public int ReservationId { get; set; }
        public string Direction { get; set; }
        public double SeatPrice { get; set; }
        public int SeatIndex { get; set; }

        public int SeatRow => (SeatIndex / NumberOfColumns) + 1;
        public int SeatColumn => (SeatIndex % NumberOfColumns) + 1;
        public string SeatName => SeatRow.ToString() + Convert.ToChar(64 + SeatColumn);

        public override string ToString()
        {
            return SeatName;
        }
        public Reservations Reservation { get; set; }
    }
}
