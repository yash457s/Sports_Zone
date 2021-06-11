using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            UserAddresses = new HashSet<UserAddresses>();
            UserMobileNumbers = new HashSet<UserMobileNumbers>();
        }

        public string UserId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual CustomerInfo CustomerInfo { get; set; }
        public virtual ICollection<UserAddresses> UserAddresses { get; set; }
        public virtual ICollection<UserMobileNumbers> UserMobileNumbers { get; set; }
    }
}
