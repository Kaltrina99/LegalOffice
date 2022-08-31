using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.ReclaimLossesDTO;
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
        public Task<ReclaimLossesCaseResponseDTO> GetRLCase(ReclaimLossesGetCaseDTO objDTO);
        public Task<IEnumerable<ReclaimLossesGetAllCasesResponseDTO>> GetAllRLCases(ReclaimLossesGetAllCasesDTO objDTO);
        public Task<CaseInputResponseDTO> GetRLCaseInputs(CaseInputDataDTO objDTO);

        public Task<ReclaimLossesCaseHistoryResponseDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<IEnumerable<ReclaimLossesCaseHistoryResponseDTO>> GetRLCaseHistory(ReclaimLossesGetCaseHistoryDTO objDTO);

        public Task<ReclaimLossesCaseNotificationResponseDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        public Task<ReclaimLossesCaseNotificationResponseDTO> GetRLCaseNotification(ReclaimLossesGetCaseNotificationsDTO objDTO);
        public Task<ReclaimLossesCaseNotificationInvoicesResponseDTO> GetRLCaseNotificationInvioce(ReclaimLossesGetCaseNotificationsDTO objDTO);

        public Task<ReclaimLossesAgreementResponseDTO> CUDRLAgreement(ReclaimLossesAgreementDTO objDTO);
        public Task<ReclaimLossesAgreementResponseDTO> GetRLAgreement(ReclaimLossesGetAgreementDTO objDTO);
        public Task<IEnumerable<ReclaimLossesGetAllAgreementResponseDTO>> GetAllRLAgreements(ReclaimLossesGetAllAgreementsDTO objDTO);
    }
}
