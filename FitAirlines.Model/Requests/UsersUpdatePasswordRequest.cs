using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class UsersUpdatePasswordRequest
    {
        [Required]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string NewPassword { get; set; }
    }
}
