using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class ApStatus
    {
        public ApStatus()
        {
            ApHistories = new HashSet<ApHistory>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ApHistory> ApHistories { get; set; }
    }
}
