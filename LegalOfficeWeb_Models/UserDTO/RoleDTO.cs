using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleNameAl { get; set; }
        public bool? Active { get; set; }
    }
}
