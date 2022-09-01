using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalOfficeWeb_Models.CaseHistoryDTO;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface ICaseHistoryRepository
    {
        public Task<CaseHistoryResponseDTO> CUDRLCaseHistory(CUDCaseHistoryDTO objDTO);
        public Task<IEnumerable<CaseHistoryResponseDTO>> GetRLCaseHistory(CaseHistoryDataDTO objDTO);
    }
}
