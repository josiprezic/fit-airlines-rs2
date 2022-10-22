using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public int UserRoleId { get; set; }
        public string Title { get; set; }
        public bool IsAbleToAddNewUsers { get; set; }
        public bool IsAbleToAddNewOffers { get; set; }
        public bool IsAbleToAddNewFlights { get; set; }
        public bool IsAbleToAddNewPlanes { get; set; }
        public bool IsAbleToAddUserCredits { get; set; }
        public bool IsAbleToAddNewReservations { get; set; }
        public bool IsAbleToAddNewPlaces { get; set; }
        public bool IsSuperUser { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
