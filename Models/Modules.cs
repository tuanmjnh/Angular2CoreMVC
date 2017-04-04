using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class Modules
    {
        public Guid Id { get; set; }
        public string AppKey { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string MenuId { get; set; }
        public int Orders { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Flag { get; set; }
        public string Extras { get; set; }
    }
}
