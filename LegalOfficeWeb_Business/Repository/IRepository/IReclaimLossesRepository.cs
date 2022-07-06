using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IReclaimLossesRepository
    {
        public Task<ReclaimLossesCaseDTO> CreateRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLCase(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLCases(int? id = null);
    }
}
