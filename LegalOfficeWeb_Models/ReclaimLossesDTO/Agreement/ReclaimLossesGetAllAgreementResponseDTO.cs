using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesGetAllAgreementResponseDTO
    {
        public int AgreementId { get; set; }
        public int? CaseId { get; set; }
        public int? CaseHistoryId { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
        public string? CustomerName { get; set; }
        public string? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? CusAddress { get; set; }
        public string? CustomerRepresentative { get; set; }
        public string? CrphoneNr { get; set; }
        public string? CridentityNr { get; set; }
        public string? DocumentPath { get; set; }
        public decimal? AgrAmount { get; set; }
        public int? InsNo { get; set; }
        public string? AgrCredit { get; set; }
        public decimal RemainingDebt { get; set; }
    }
}
