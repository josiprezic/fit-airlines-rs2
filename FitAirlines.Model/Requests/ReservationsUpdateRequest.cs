using System;
using System.ComponentModel.DataAnnotations;

namespace FitAirlines.Model.Requests
{
    public class ReservationsUpdateRequest
    {
        [Required]
        public bool? IsValid { get; set; }

        public string Notes { get; set; }

        [Required]
        public int SeatIndexDeparture { get; set; }
        [Required]
        public int SeatIndexReturn { get; set; }

    }
}
