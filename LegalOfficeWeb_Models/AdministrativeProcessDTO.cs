using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class AdministrativeProcessDTO
    {
        public string Source { get; set; }
        public int ApmainId { get; set; }
        public int? CaseId { get; set; }

        public string? DebitorID { get; set; }
        public string? Subdistrict { get; set; }
        public string? Category { get; set; }
        public string? Subcategory { get; set; }
        public string? CustumerName { get; set; }
        public string? PersonalNumber { get; set; }

        public double? CompensationAmount { get; set; }
        public double? EvaluatedAmount { get; set; }
        public double? OfferedAmount { get; set; }
        public double? PaidAmount { get; set; }
        public string? Comment { get; set; }
        public int? StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
    }
}
