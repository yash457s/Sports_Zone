using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
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
