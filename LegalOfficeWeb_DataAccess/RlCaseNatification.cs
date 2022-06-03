using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlCaseNatification
    {
        public RlCaseNatification()
        {
            RlCninvoices = new HashSet<RlCninvoice>();
        }

        public int Cnid { get; set; }
        public int? CaseHistoryId { get; set; }
        public int? CaseId { get; set; }
        public string? CustomerName { get; set; }
        public int? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public int? WaitingDays { get; set; }
        public string? DocumentPath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }

        public virtual RlCaseHistory? CaseHistory { get; set; }
        public virtual ICollection<RlCninvoice> RlCninvoices { get; set; }
    }
}
