using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgrinvoice
    {
        public int Id { get; set; }
        public int? AgreementId { get; set; }
        public int? CaseId { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceIdccp { get; set; }
        public int? InvoiceIdrl { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? InvoiceAmountInv { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
    }
}
