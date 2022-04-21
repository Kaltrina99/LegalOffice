using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlSubReason
    {
        public CvlSubReason()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int CvlSubReasonId { get; set; }
        public string? CvlSubReasonName { get; set; }
        public string? CvlSubReasonNameAl { get; set; }
        public bool? CvlSubReasonIsActive { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
