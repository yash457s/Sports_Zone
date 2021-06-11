using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class UserAddresses
    {
        public string Username { get; set; }
        public string Address { get; set; }

        public virtual Users UsernameNavigation { get; set; }
    }
}
