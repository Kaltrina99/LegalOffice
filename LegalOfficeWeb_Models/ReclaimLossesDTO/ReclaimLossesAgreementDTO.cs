using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesAgreementDTO
    {
        public int? UserId { get; set; }
        public int? AgreementId { get; set; }
        public int? CaseId { get; set; }
        public int? CaseHistoryId { get; set; }
        public string? CustomerName { get; set; }
        public string? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? CustomerRepresentative { get; set; }
        public string? CRPhoneNr { get; set; }
        public string? CRIdentityNr { get; set; }
        public string? InvoiceIDs { get; set; }
        public string? InsIDs { get; set; }
        public string? Comment { get; set; }
        public int? ProcessType { get; set; }
    }
}
