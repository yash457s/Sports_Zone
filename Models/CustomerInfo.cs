using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class CustomerInfo
    {
        public CustomerInfo()
        {
            Cart = new HashSet<Cart>();
            Invoice = new HashSet<Invoice>();
            Payment = new HashSet<Payment>();
        }

        public string CusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual Users Cus { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
