using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface ICaseRepository
    {
        public Task<CasesResponseDTO> CUDRLCase(CUDCaseDTO objDTO);
        public Task<CasesResponseDTO> GetRLCase(CaseDataDTO objDTO);
        public Task<IEnumerable<CasesResponseDTO>> GetAllRLCases(CaseDataDTO objDTO);
        public Task<CaseInputResponseDTO> GetRLCaseInputs(CaseInputDataDTO objDTO);
    }
}
