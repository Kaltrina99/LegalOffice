using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesGetCaseDTO
    {
        public int UserId { get; set; }
        public int CaseId { get; set; }
        public string District { get; set; }
    }
}
