using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
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
