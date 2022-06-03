using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlJudge
    {
        public CvlJudge()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int JudgeId { get; set; }
        public string? JudgeName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
