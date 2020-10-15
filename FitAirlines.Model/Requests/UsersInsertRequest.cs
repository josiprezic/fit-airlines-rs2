using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class UsersInsertRequest
    {
        [Required] 
        public string FirstName { get; set; }
        
        [Required] 
        public string LastName { get; set; }
        
        [Required] 
        public DateTime BirthDate { get; set; }
        
        [Required] 
        public string Gender { get; set; }
        
        [Required] 
        public string Username { get; set; }
        
        [Required] 
        public string Password { get; set; }
        
        public string Email { get; set; }
        
        [Required] 
        public string ContactNumber { get; set; }
        
        public byte[] Picture { get; set; }
        
        public double Credit { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public bool? IsActive { get; set; }
        
        [Required] 
        public int UserRoleId { get; set; }
        
        [Required] 
        public int MembershipTypeId { get; set; }
        
        [Required]
        public string PasswordConfirmation { get; set; }
    }
}
