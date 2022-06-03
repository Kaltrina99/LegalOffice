using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlRiskLevel
    {
        public CvlRiskLevel()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int RiskLevelId { get; set; }
        public string? RiskLevelName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
