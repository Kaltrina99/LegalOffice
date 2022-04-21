using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgreement
    {
        public RlAgreement()
        {
            RlAgrNatifications = new HashSet<RlAgrNatification>();
            RlAgrinstallments = new HashSet<RlAgrinstallment>();
            RlAgrinvoices = new HashSet<RlAgrinvoice>();
            RlInvoicePayments = new HashSet<RlInvoicePayment>();
        }

        public int AgreementId { get; set; }
        public int? CaseHistoryId { get; set; }
        public int? CaseId { get; set; }
        public int? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public string? CustomerRepresentative { get; set; }
        public string? CrphoneNr { get; set; }
        public int? CridentityNr { get; set; }
        public string? DocumentPath { get; set; }

        public virtual RlCaseHistory? CaseHistory { get; set; }
        public virtual ICollection<RlAgrNatification> RlAgrNatifications { get; set; }
        public virtual ICollection<RlAgrinstallment> RlAgrinstallments { get; set; }
        public virtual ICollection<RlAgrinvoice> RlAgrinvoices { get; set; }
        public virtual ICollection<RlInvoicePayment> RlInvoicePayments { get; set; }
    }
}
