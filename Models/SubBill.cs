using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class SubBill
    {
        public Guid Id { get; set; }
        public Guid? IdKey { get; set; }
        public string CodeKey { get; set; }
        public Guid? ItemId { get; set; }
        public string Title { get; set; }
        public long? Quantity { get; set; }
        public decimal? PriceOld { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Orders { get; set; }
        public int? Flag { get; set; }
        public string Extras { get; set; }

        public virtual Bill IdKeyNavigation { get; set; }
    }
}
