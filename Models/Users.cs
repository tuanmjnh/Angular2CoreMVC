using System;
using System.Collections.Generic;

namespace Angular2CoreMVC.Models
{
    public partial class Users
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Roles { get; set; }
        public int? Orders { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public Guid? StaffId { get; set; }
        public int? Flag { get; set; }
        public string Extras { get; set; }
    }
}
