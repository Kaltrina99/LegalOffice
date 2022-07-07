using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IReclaimLossesService
    {
        public Task<ReclaimLossesCaseResponseDTO> CUDRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseResponseDTO> GetRLCase(int id);
        public Task<IEnumerable<ReclaimLossesCaseResponseDTO>> GetAllRLCases();
    }
}
