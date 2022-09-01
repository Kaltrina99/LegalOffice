using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.CaseDTO
{
    public class CaseDataDTO
    {
        public CaseDataDTO(int userId, int? caseId, string district)
        {
            UserId = userId;
            CaseId = caseId;
            District = district;
        }
        public CaseDataDTO(int userId, string district)
        {
            UserId = userId;
            CaseId = 0;
            District = district;
        }
        public CaseDataDTO()
        {
        }

        public int UserId { get; set; }
        public int? CaseId { get; set; }
        public string District { get; set; }
    }
}
