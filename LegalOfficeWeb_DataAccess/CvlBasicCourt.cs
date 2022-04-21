using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlBasicCourt
    {
        public CvlBasicCourt()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int CvlBasicCourtId { get; set; }
        public string? CvlBasicCourtName { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
