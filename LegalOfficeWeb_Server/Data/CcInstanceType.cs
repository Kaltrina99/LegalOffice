using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CcInstanceType
    {
        public CcInstanceType()
        {
            CcDetails = new HashSet<CcDetail>();
        }

        public int InstanceTypeId { get; set; }
        public string? InstanceName { get; set; }
        public string? InstanceNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CcDetail> CcDetails { get; set; }
    }
}
