using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class GroupItem
    {
        public Guid Id { get; set; }
        public string AppKey { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? ItemId { get; set; }
        public int? Orders { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Flag { get; set; }
        public string Extras { get; set; }

        public virtual Group Group { get; set; }
        public virtual Item Item { get; set; }
    }
}
