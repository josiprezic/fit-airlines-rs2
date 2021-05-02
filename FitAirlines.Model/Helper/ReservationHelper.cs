using System;
using System.Collections.Generic;
using System.Text;

namespace FitAirlines.Model.Helper
{
    // TODO: JR remove helper class
    public static class ReservationHelper
    {
        public static int numberOfColumns = 6;

        public static string SeatName(int seatIndex)
        {
            return SeatRow(seatIndex).ToString() + Convert.ToChar(64 + SeatColumn(seatIndex));
        }

        public static int SeatRow(int seatIndex)
        {
            return (seatIndex / numberOfColumns) + 1;
        }
        public static int SeatColumn(int seatIndex)
        {
            return (seatIndex % numberOfColumns) + 1;
        }
    }
}
