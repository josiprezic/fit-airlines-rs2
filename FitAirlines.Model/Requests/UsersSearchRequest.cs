using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitAirlines.Model.Requests
{
    public class UsersSearchRequest
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public int MembershipTypeId { get; set; }

        public bool ShowOnlyActive { get; set; }
    }
}
