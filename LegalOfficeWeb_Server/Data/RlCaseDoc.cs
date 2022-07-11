using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class RlCaseDoc
    {
        public int CaseDocId { get; set; }
        public int? CaseId { get; set; }
        public string? DocName { get; set; }
        public string? DocPath { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }

        public virtual RlCase? Case { get; set; }
    }
}
