using LegalOfficeWeb_Models.MainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAPMainRepository
    {
        public Task<MainResponseDTO> CUDMain(CUDMainDTO objDTO);
        public Task<IEnumerable<MainResponseDTO>> GetMain(MainDataDTO objDTO);
    }
}
