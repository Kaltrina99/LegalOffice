using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class AdministrativeProcessStatusesDTO
    {
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
        public bool? Active { get; set; }
    }
}
