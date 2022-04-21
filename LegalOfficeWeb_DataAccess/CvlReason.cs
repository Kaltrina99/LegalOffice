using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlReason
    {
        public CvlReason()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int CvlReasonId { get; set; }
        public string? CvlReasonName { get; set; }
        public string? CvlReasonNameAl { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
