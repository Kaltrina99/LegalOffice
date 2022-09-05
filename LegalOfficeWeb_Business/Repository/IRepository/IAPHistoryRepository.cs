using LegalOfficeWeb_Models.HistoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAPHistoryRepository
    {
        public Task<HistoryResponseDTO> CUDAPHistory(CUDHistoryDTO objDTO);
        public Task<IEnumerable<HistoryResponseDTO>> GetAPHistory(HistoryDataDTO objDTO);
    }
}
