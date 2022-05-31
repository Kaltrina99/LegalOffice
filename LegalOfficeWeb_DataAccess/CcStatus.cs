using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class CcStatus
    {
        public CcStatus()
        {
            CcMains = new HashSet<CcMain>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CcMain> CcMains { get; set; }
    }
}
