using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Reservations
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public DateTime ReservationDate { get; set; }
        public double BaseTicketPrice { get; set; }
        public double TotalDiscountPercentage { get; set; }
        public bool? IsValid { get; set; }
        public int? CashierId { get; set; }
        public string Notes { get; set; }

        public string SeatDeparture { get; set; }
        public string SeatReturn { get; set; }

        public Users Cashier { get; set; }
        public Flights Flight { get; set; }
        public Users User { get; set; }

        public string ClientType => User.FirstName + " " + User.LastName + " (" + User.MembershipType.Title + ")";
        public string FlightOffer => Flight.City.CityName + ", " + Flight.CountryName + " (" + Flight.Offer.OfferName + ")";
        public string Discount => TotalDiscountPercentage + "%";
        public string TicketPrice => (BaseTicketPrice * (1 - TotalDiscountPercentage / 100)).ToString("0.00");
    }
}
