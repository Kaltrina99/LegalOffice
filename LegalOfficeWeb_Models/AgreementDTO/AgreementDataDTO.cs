using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementDTO
{
    public class AgreementDataDTO
    {
        public AgreementDataDTO()
        {
        }
        public AgreementDataDTO(int userID,string? district)
        {
            UserId = userID;
            District = district;
        }
        public AgreementDataDTO(int userID, int agreementId, int caseId)
        {
            UserId=userID;
            AgreementId = agreementId;
            CaseId = caseId;
        }

        public int UserId { get; set; }
        public string? District { get; set; }
        public int AgreementId { get; set; }
        public int CaseId { get; set; }
    }
}
