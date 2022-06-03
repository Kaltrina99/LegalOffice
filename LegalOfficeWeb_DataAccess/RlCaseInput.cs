using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlCaseInput
    {
        public int CaseIputId { get; set; }
        public int? CaseId { get; set; }
        public string? Subdistrict { get; set; }
        public int? AmeterId { get; set; }
        public string? TariffId { get; set; }
        public string? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public string? Municipality { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }

        public virtual RlCase? Case { get; set; }
    }
}
