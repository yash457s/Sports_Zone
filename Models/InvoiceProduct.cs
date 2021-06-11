using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sports_Zone_Web_API.Models
{
    public partial class InvoiceProduct
    {
        public string InvId { get; set; }
        public string ProId { get; set; }
        public int? Quantity { get; set; }

        public virtual Invoice Inv { get; set; }
        public virtual Product Pro { get; set; }
    }
}
