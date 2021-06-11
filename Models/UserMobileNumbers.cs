using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sports_Zone_Web_API.Models
{
    public partial class UserMobileNumbers
    {
        public string Username { get; set; }
        public string MobileNumber { get; set; }

        public virtual Users UsernameNavigation { get; set; }
    }
}
