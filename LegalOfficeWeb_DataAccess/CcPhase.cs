using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CcPhase
    {
        public int PhaseId { get; set; }
        public int? CaseId { get; set; }
        public int? PhaseTypeId { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? ProcessNr { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedComment { get; set; }
        public bool? Active { get; set; }

        public virtual CcPhaseType? PhaseType { get; set; }
    }
}
