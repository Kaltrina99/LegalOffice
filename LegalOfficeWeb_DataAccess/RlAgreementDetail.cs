using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgreementDetail
    {
        public int AgdetailId { get; set; }
        public int? AgreementId { get; set; }
        public string? CustomerName { get; set; }
        public string? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? CusAddress { get; set; }
        public string? CustomerRepresentative { get; set; }
        public string? CrphoneNr { get; set; }
        public string? CridentityNr { get; set; }
        public string? DocumentPath { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Active { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
    }
}
