using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class UserMobileNumbers
    {
        public string Username { get; set; }
        public string MobileNumber { get; set; }

        public virtual Users UsernameNavigation { get; set; }
    }
}
