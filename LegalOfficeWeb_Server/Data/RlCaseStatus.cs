using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class RlCaseStatus
    {
        public RlCaseStatus()
        {
            RlCaseHistories = new HashSet<RlCaseHistory>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RlCaseHistory> RlCaseHistories { get; set; }
    }
}
