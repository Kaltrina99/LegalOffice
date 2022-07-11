using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgrInvoice
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
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
    }
}
