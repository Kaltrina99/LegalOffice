using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.CaseHistoryDTO
{
    public class CaseHistoryResponseDTO
    {
        public int? CaseHistoryId { get; set; }
        public int? CaseId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAL { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public string? CreatedComment { get; set; }
        public string? CreatedUSerName { get; set; }
    }
}
