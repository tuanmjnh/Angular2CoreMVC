using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class Settings
    {
        public Guid Id { get; set; }
        public string ModuleKey { get; set; }
        public string SubKey { get; set; }
        public string Value { get; set; }
        public string SubValue { get; set; }
        public string Desc { get; set; }
        public int? Orders { get; set; }
        public int? Flag { get; set; }
        public string Extras { get; set; }
    }
}
