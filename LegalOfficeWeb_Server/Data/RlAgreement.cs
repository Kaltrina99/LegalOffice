using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class RlAgreement
    {
        public RlAgreement()
        {
            RlAgrInstallments = new HashSet<RlAgrInstallment>();
            RlAgrInvoicePayments = new HashSet<RlAgrInvoicePayment>();
            RlAgrInvoices = new HashSet<RlAgrInvoice>();
            RlAgrNotifications = new HashSet<RlAgrNotification>();
            RlAgreementDetails = new HashSet<RlAgreementDetail>();
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
        public virtual ICollection<RlAgrInstallment> RlAgrInstallments { get; set; }
        public virtual ICollection<RlAgrInvoicePayment> RlAgrInvoicePayments { get; set; }
        public virtual ICollection<RlAgrInvoice> RlAgrInvoices { get; set; }
        public virtual ICollection<RlAgrNotification> RlAgrNotifications { get; set; }
        public virtual ICollection<RlAgreementDetail> RlAgreementDetails { get; set; }
    }
}
