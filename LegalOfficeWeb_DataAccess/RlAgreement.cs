using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgreement
    {
        public RlAgreement()
        {
            RlAgrNatifications = new HashSet<RlAgrNatification>();
            RlAgreementDetails = new HashSet<RlAgreementDetail>();
            RlAgrinstallments = new HashSet<RlAgrinstallment>();
            RlAgrinvoices = new HashSet<RlAgrinvoice>();
            RlInvoicePayments = new HashSet<RlInvoicePayment>();
        }

        public int AgreementId { get; set; }
        public int? CaseId { get; set; }
        public int? CaseHistoryId { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual RlCase? Case { get; set; }
        public virtual ICollection<RlAgrNatification> RlAgrNatifications { get; set; }
        public virtual ICollection<RlAgreementDetail> RlAgreementDetails { get; set; }
        public virtual ICollection<RlAgrinstallment> RlAgrinstallments { get; set; }
        public virtual ICollection<RlAgrinvoice> RlAgrinvoices { get; set; }
        public virtual ICollection<RlInvoicePayment> RlInvoicePayments { get; set; }
    }
}
