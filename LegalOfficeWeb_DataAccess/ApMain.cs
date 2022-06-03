using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class ApMain
    {
        public ApMain()
        {
            ApHistories = new HashSet<ApHistory>();
        }

        public int ApmainId { get; set; }
        public int? CaseId { get; set; }
        public double? CompensationAmount { get; set; }
        public double? EvaluatedAmount { get; set; }
        public double? OfferedAmount { get; set; }
        public double? PaidAmount { get; set; }
        public string? Comment { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ApHistory> ApHistories { get; set; }
    }
}
