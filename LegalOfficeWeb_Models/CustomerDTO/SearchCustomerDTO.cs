using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class SearchCustomerDTO
    {
        public int UserId { get; set; }
        public string AgencyId { get; set; }
        public int EldebitorId { get; set; }
        public int AMeterId { get; set; }
    }
}
