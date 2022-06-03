using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
