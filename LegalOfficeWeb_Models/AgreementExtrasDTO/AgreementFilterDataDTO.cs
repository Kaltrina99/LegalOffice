using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class AgreementFilterDataDTO
    {
        public AgreementFilterDataDTO()
        {
        }

        public AgreementFilterDataDTO(int userId, int agreementId)
        {
            UserId = userId;
            AgreementId = agreementId;
        }

        public AgreementFilterDataDTO(int userId, int agreementId, int caseId)
        {
            UserId = userId;
            AgreementId = agreementId;
            CaseId = caseId;
        }

        public int UserId { get; set; }
        public int AgreementId { get; set; }
        public int CaseId { get; set; }
    }
}
