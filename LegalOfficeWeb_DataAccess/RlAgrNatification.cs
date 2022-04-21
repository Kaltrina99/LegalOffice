using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgrNatification
    {
        public int Id { get; set; }
        public int? AgreementId { get; set; }
        public int? CaseId { get; set; }
        public string? NartificationText { get; set; }
        public string? PhoneNr { get; set; }
        public string? Email { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
    }
}
