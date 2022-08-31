using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.ReclaimLossesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IReclaimLossesRepository
    {
        #region RL Case
        public Task<ReclaimLossesCaseResponseDTO> CUDRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseResponseDTO> GetRLCase(ReclaimLossesGetCaseDTO objDTO);
        public Task<IEnumerable<ReclaimLossesGetAllCasesResponseDTO>> GetAllRLCases(ReclaimLossesGetAllCasesDTO objDTO);
        public Task<CaseInputResponseDTO> GetRLCaseInputs(CaseInputDataDTO objDTO);
        #endregion
        #region RL CaseHistory
        public Task<ReclaimLossesCaseHistoryResponseDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<IEnumerable<ReclaimLossesCaseHistoryResponseDTO>> GetRLCaseHistory(ReclaimLossesGetCaseHistoryDTO objDTO);
        #endregion
        #region RL CaseNotification
        public Task<ReclaimLossesCaseNotificationResponseDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        public Task<ReclaimLossesCaseNotificationResponseDTO> GetRLCaseNotification(ReclaimLossesGetCaseNotificationsDTO objDTO);
        public Task<ReclaimLossesCaseNotificationInvoicesResponseDTO> GetRLCaseNotificationInvioce(ReclaimLossesGetCaseNotificationsDTO objDTO);
        #endregion
        //RL Agreement
        public Task<ReclaimLossesAgreementResponseDTO> CUDRLAgreement(ReclaimLossesAgreementDTO objDTO);
        public Task<ReclaimLossesAgreementResponseDTO> GetRLAgreement(ReclaimLossesGetAgreementDTO objDTO);
        public Task<IEnumerable<ReclaimLossesGetAllAgreementResponseDTO>> GetAllRLAgreements(ReclaimLossesGetAllAgreementsDTO objDTO);

        //RL AgreementNotification
        public Task<ReclaimLossesAgreementNotificationDTO> CUDRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        public Task<ReclaimLossesAgreementNotificationDTO> GetRLAgreementNotification(int id);
        public Task<IEnumerable<ReclaimLossesAgreementNotificationDTO>> GetAllRLAgreementNotifications();

        //RL ManualPayment
        public Task<ReclaimLossesManualPaymentDTO> CUDRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id);
    }
}
