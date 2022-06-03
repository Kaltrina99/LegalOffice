using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlDefendantCompany
    {
        public CvlDefendantCompany()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int DefendantCompanyId { get; set; }
        public string? DefendantCompanyName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
