using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sports_Zone_Web_API.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            Categories = new HashSet<Categories>();
        }

        public string ProId { get; set; }
        public string ProName { get; set; }
        public string ProDescription { get; set; }
        public decimal? ProPrice { get; set; }
        public int? Stock { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Categories> Categories { get; set; }
    }
}
