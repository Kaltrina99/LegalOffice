using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class CcMain
    {
        public int CcmainId { get; set; }
        public int? CaseId { get; set; }
        public int? DecisionTypeId { get; set; }
        public string? DecisionComment { get; set; }
        public int? StatusId { get; set; }
        public string? StatusComment { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual CcDecisionType? DecisionType { get; set; }
        public virtual CcStatus? Status { get; set; }
    }
}
