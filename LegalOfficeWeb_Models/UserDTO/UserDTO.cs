using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class UserDTO
    {
        public int? UserId { get; set; }
        public int? CreatedUser { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FullName { get; set; }
        public string? RoleIds { get; set; }
        public int? UserType { get; set; }
        public int? ProcessType { get; set; }
    }
}
