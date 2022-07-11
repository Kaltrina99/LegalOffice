using LegalOfficeWeb_Models;
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
        #endregion

        #region RL CaseHistory
        public Task<ReclaimLossesCaseHistoryResponseDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<IEnumerable<ReclaimLossesCaseHistoryResponseDTO>> GetRLCaseHistory(ReclaimLossesGetCaseHistoryDTO objDTO);
        #endregion
        //RL CaseNotification
        public Task<ReclaimLossesCaseNotificationDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        public Task<ReclaimLossesCaseNotificationDTO> GetRLCaseNotification(int id);

        //RL Agreement
        public Task<ReclaimLossesAgreementDTO> CUDRLAgreement(ReclaimLossesAgreementDTO objDTO);
        public Task<ReclaimLossesAgreementDTO> GetRLAgreement(int id);
        public Task<IEnumerable<ReclaimLossesAgreementDTO>> GetAllRLAgreements();

        //RL AgreementNotification
        public Task<ReclaimLossesAgreementNotificationDTO> CUDRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        public Task<ReclaimLossesAgreementNotificationDTO> GetRLAgreementNotification(int id);
        public Task<IEnumerable<ReclaimLossesAgreementNotificationDTO>> GetAllRLAgreementNotifications();

        //RL ManualPayment
        public Task<ReclaimLossesManualPaymentDTO> CUDRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id);
    }
}
