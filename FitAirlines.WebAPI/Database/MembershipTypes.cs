using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class MembershipTypes
    {
        public MembershipTypes()
        {
            Flights = new HashSet<Flights>();
            Users = new HashSet<Users>();
        }

        public int MembershipTypeId { get; set; }
        public string Title { get; set; }
        public string ShortInfo { get; set; }
        public double MembershipPrice { get; set; }
        public bool IsPriorityAvailable { get; set; }
        public bool IsExtraBaggageAvailable { get; set; }
        public bool IsFitsandwichAvailable { get; set; }
        public bool IsSeatChangeAvailable { get; set; }
        public bool IsBonusDrinkAvailable { get; set; }
        public bool IsBonusMealAvailable { get; set; }
        public double BasicTicketDiscount { get; set; }
        public double BasicFoodDrinkDiscount { get; set; }

        public ICollection<Flights> Flights { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
