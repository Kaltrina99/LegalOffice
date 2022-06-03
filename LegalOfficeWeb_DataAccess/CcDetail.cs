using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CcDetail
    {
        public int DetailId { get; set; }
        public int? CaseId { get; set; }
        public string? CourtCaseNr { get; set; }
        public string? ChargeType { get; set; }
        public DateTime? DateOfDelivery { get; set; }
        public int? InstanceTypeId { get; set; }
        public string? LegalName { get; set; }
        public string? LegalPerson { get; set; }
        public string? LegalComment { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual CcInstanceType? InstanceType { get; set; }
    }
}
