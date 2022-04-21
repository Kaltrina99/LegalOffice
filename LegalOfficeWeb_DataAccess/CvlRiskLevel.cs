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

        public int CvlRiskLevelId { get; set; }
        public string? CvlRiskLevelName { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
