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

        public int CvlJudgeId { get; set; }
        public string? CvlJudgeName { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
