using System;
using System.Collections.Generic;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class Invoice
    {
        public string InvId { get; set; }
        public string CusId { get; set; }
        public DateTime? Date { get; set; }

        public virtual CustomerInfo Cus { get; set; }
    }
}
