using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.AgreementDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAgreementRepository
    {
        public Task<AgreementResponseDTO> CUDRLAgreement(CUDAgreementDTO objDTO);
        public Task<AgreementResponseDTO> GetRLAgreement(AgreementDataDTO objDTO);
        public Task<IEnumerable<AgreementResponseDTO>> GetAllRLAgreements(AgreementDataDTO objDTO);
    }
}
