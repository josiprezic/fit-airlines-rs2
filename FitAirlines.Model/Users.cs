using System;
using System.Collections.Generic;

namespace FitAirlines.Model
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        
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
    }
}
