using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlCaseHistory
    {
        public RlCaseHistory()
        {
            RlCaseNatifications = new HashSet<RlCaseNatification>();
        }

        public int CaseHistoryId { get; set; }
        public int? CaseId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public string? CreatedComment { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual RlCase? Case { get; set; }
        public virtual RlCaseStatus? Status { get; set; }
        public virtual ICollection<RlCaseNatification> RlCaseNatifications { get; set; }
    }
}
