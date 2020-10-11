using System;
using System.Collections.Generic;

namespace FitAirlines.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            Flights = new HashSet<Flights>();
            ReservationsCashier = new HashSet<Reservations>();
            ReservationsUser = new HashSet<Reservations>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public byte[] Picture { get; set; }
        public double Credit { get; set; }
        public DateTime StartDate { get; set; }
        public bool? IsActive { get; set; }
        public int UserRoleId { get; set; }
        public int MembershipTypeId { get; set; }

        public MembershipTypes MembershipType { get; set; }
        public UserRoles UserRole { get; set; }
        public ICollection<Flights> Flights { get; set; }
        public ICollection<Reservations> ReservationsCashier { get; set; }
        public ICollection<Reservations> ReservationsUser { get; set; }
    }
}
