using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CcDecisionType
    {
        public CcDecisionType()
        {
            CcMains = new HashSet<CcMain>();
        }

        public int DecisionTypeId { get; set; }
        public string? DecisionTypeName { get; set; }
        public string? DecisionTypeNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CcMain> CcMains { get; set; }
    }
}
