using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class CcPhaseType
    {
        public CcPhaseType()
        {
            CcPhases = new HashSet<CcPhase>();
        }

        public int PhaseTypeId { get; set; }
        public string? PhaseTypeName { get; set; }
        public string? PhaseTypeNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CcPhase> CcPhases { get; set; }
    }
}
