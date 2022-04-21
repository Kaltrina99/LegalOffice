using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Blocked { get; set; }
        public int? BlockedUser { get; set; }
        public string? BlockedDate { get; set; }
        public int? EmpId { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
