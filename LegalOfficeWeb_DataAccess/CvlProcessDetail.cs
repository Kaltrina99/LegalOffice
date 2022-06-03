using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlProcessDetail
    {
        public int ProcessDetailId { get; set; }
        public int? ProcessId { get; set; }
        public int? ProcessStatusId { get; set; }
        public DateTime? PdDate { get; set; }
        public DateTime? PdCreatedDate { get; set; }
        public int? PdCreatedUser { get; set; }
        public string? PdCreatedComment { get; set; }
        public string? PdDocumentPath { get; set; }
        public bool? PdDeleted { get; set; }
        public int? PdDeletedUser { get; set; }
        public DateTime? PdDeletedDate { get; set; }
        public string? PdDeletedComment { get; set; }
        public decimal? CaseFinishedAmount { get; set; }
        public int? FinishedKedsdebitor { get; set; }

        public virtual CvlProcess? Process { get; set; }
        public virtual CvlProcessStatus? ProcessStatus { get; set; }
    }
}
