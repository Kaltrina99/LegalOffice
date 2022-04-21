using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlCase
    {
        public RlCase()
        {
            RlCaseHistories = new HashSet<RlCaseHistory>();
        }

        public int CaseId { get; set; }
        public string? CaseNr { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public int? AmeterId { get; set; }
        public string? Subdistrict { get; set; }
        public string? CustomerName { get; set; }
        public int? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public string? InitiatedDeparment { get; set; }
        public int? LastStatusId { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public int? LastStatusUser { get; set; }
        public int? MainResponsibleUserId { get; set; }
        public int? SecondResponsibleUserId { get; set; }
        public string? SourceApp { get; set; }
        public int? SourceId { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedComment { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual ICollection<RlCaseHistory> RlCaseHistories { get; set; }
    }
}
