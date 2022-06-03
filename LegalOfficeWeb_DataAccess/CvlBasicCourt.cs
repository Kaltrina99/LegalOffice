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

        public int BasicCourtId { get; set; }
        public string? BasicCourtName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
