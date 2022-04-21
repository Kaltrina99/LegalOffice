using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlProcessStatus
    {
        public CvlProcessStatus()
        {
            CvlProcessDetails = new HashSet<CvlProcessDetail>();
        }

        public int CvlProcessStatusId { get; set; }
        public string? CvlProcessStatusName { get; set; }
        public string? CvlProcessStatusNameAl { get; set; }
        public bool? CvlProcessStatusIsActive { get; set; }

        public virtual ICollection<CvlProcessDetail> CvlProcessDetails { get; set; }
    }
}
