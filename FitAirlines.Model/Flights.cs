using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Flights
    {
        public int FlightId { get; set; }
        public int CityId { get; set; }
        public int DestinationAirportId { get; set; }
        public int OfferId { get; set; }
        public int PlaneId { get; set; }
        public int AddedByUserId { get; set; }
        public DateTime AddedDate { get; set; }
        public string VoucherCode { get; set; }
        public double? VoucherDiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PilotFullName { get; set; }
        public TimeSpan FlightDuration { get; set; }
        public double Price { get; set; }
        public string ShortInfo { get; set; }
        public byte[] Picture { get; set; }
        public string Notes { get; set; }
        public int AvailableToMemberTypeId { get; set; }
        public bool? IsActive { get; set; }

        public Users AddedByUser { get; set; }
        public MembershipTypes AvailableToMemberType { get; set; }
        public Cities City { get; set; }
        public Airports DestinationAirport { get; set; }
        public Offers Offer { get; set; }
        public Planes Plane { get; set; }

        public int Capacity => Plane?.Capacity ?? 0;

        public string CountryName => City?.Country?.CountryName ?? null;
    }
}
