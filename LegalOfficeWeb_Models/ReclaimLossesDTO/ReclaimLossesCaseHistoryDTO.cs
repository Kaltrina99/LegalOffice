using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesCaseHistoryDTO
    {
        public int? UserId { get; set; }
        public int? CaseHistoryID { get; set; }
        public int? CaseId { get; set; }
        public int? StatusId { get; set; }
        public string? StatusDate { get; set; }
        public string? CreatedComment { get; set; }
        public int? ProcessType { get; set; }
    }
}
