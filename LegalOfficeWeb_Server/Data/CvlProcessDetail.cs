using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlProcessDetail
    {
        public int ProcessDetailId { get; set; }
        public int? ProcessId { get; set; }
        public int? ProcessStatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public string? CreatedComment { get; set; }
        public string? DocumentPath { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }
        public decimal? CaseFinishedAmount { get; set; }
        public int? FinishedKedsdebitor { get; set; }

        public virtual CvlProcess? Process { get; set; }
        public virtual CvlProcessStatus? ProcessStatus { get; set; }
    }
}
