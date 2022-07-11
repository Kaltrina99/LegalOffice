using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlLitigationLawyer
    {
        public CvlLitigationLawyer()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int LitigationLawyerId { get; set; }
        public string? LitigationLawyerName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
