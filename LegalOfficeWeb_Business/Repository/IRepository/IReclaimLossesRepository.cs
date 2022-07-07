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
        //RL Case
        public Task<ReclaimLossesCaseDTO> CUDRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseResponseDTO> GetRLCase(int id);
        public Task<IEnumerable<ReclaimLossesCaseResponseDTO>> GetAllRLCases();

        //RL CaseHistory
        public Task<ReclaimLossesCaseHistoryDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<ReclaimLossesCaseHistoryDTO> GetRLCaseHistory(int id,int caseId);
        public Task<IEnumerable<ReclaimLossesCaseHistoryDTO>> GetAllRLCaseHistories(int id);

        //RL CaseNotification
        public Task<ReclaimLossesCaseNotificationDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        public Task<ReclaimLossesCaseNotificationDTO> GetRLCaseNotification(int id);
        public Task<IEnumerable<ReclaimLossesCaseNotificationDTO>> GetAllRLCaseNotifications();

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
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLManualPayment();
    }
}
