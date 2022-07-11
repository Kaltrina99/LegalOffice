using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlSubReason
    {
        public CvlSubReason()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int SubReasonId { get; set; }
        public string? SubReasonName { get; set; }
        public string? SubReasonNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
