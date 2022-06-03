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

        public int ProcessStatusId { get; set; }
        public string? ProcessStatusName { get; set; }
        public string? ProcessStatusNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcessDetail> CvlProcessDetails { get; set; }
    }
}
