﻿using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class Bill
    {
        public Bill()
        {
            SubBill = new HashSet<SubBill>();
        }

        public Guid Id { get; set; }
        public string CodeKey { get; set; }
        public string CustomerId { get; set; }
        public long? TotalItem { get; set; }
        public long? TotalQuantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Desc { get; set; }
        public int? Orders { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Flag { get; set; }
        public string Extras { get; set; }

        public virtual ICollection<SubBill> SubBill { get; set; }
    }
}
