using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.CaseDTO
{
    public class CaseDocumentDTO
    {
        public int CaseDocId { get; set; }
        public int? CaseId { get; set; }
        public string? DocName { get; set; }
        public string? DocPath { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedUserName { get; set; }
    }
}
