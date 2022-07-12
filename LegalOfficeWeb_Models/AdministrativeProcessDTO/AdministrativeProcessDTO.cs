using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class AdministrativeProcessDTO
    {
        public int AphistoryId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? StatusComment { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
        public int? CaseId { get; set; }
        public double? CompensationAmount { get; set; }
        public double? EvaluatedAmount { get; set; }
        public double? OfferedAmount { get; set; }
        public double? PaidAmount { get; set; }
        public string? Comment { get; set; }
        public bool? Active { get; set; }

    }
}
