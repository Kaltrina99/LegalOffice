using LegalOfficeWeb_Models.CaseHistoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface ICaseHistoryService
    {
        public Task<CaseHistoryResponseDTO> CUDRLCaseHistory(CUDCaseHistoryDTO objDTO);
        public Task<IEnumerable<CaseHistoryResponseDTO>> GetRLCaseHistory(CaseHistoryDataDTO objDTO);
    }
}
