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

        public int CvlDefendantCompanyId { get; set; }
        public string? CvlDefendantCompanyName { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
