using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class CustomerNameDTO
    {
        public int UserId { get; set; }
        public string AgencyId { get; set; }
        public int EldebitorId { get; set; }
        public string? AMeterId { get; set; }
        public int? ProcessTypeId { get; set; }
    }
}
