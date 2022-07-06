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
        //public Task<ReclaimLossesCaseDTO> CreateRLCase(ReclaimLossesCaseDTO objDTO);
        //public Task<ReclaimLossesCaseDTO> UpdateRLCase(ReclaimLossesCaseDTO objDTO);
        //public Task<ReclaimLossesCaseDTO> DeleteRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLCase(int id);
        public Task<IEnumerable<ReclaimLossesCaseResponseDTO>> GetAllRLCases();

        //RL CaseHistory
        public Task<ReclaimLossesCaseHistoryDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        //public Task<ReclaimLossesCaseHistoryDTO> CreateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        //public Task<ReclaimLossesCaseHistoryDTO> UpdateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        //public Task<ReclaimLossesCaseHistoryDTO> DeleteRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<ReclaimLossesCaseHistoryDTO> GetRLCaseHistory(int id);
        public Task<IEnumerable<ReclaimLossesCaseHistoryDTO>> GetAllRLCaseHistories();

        //RL CaseNotification
        public Task<ReclaimLossesCaseNotificationDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        //public Task<ReclaimLossesCaseNotificationDTO> CreateRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        //public Task<ReclaimLossesCaseNotificationDTO> UpdateRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        //public Task<ReclaimLossesCaseNotificationDTO> DeleteRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO);
        public Task<ReclaimLossesCaseNotificationDTO> GetRLCaseNotification(int id);
        public Task<IEnumerable<ReclaimLossesCaseNotificationDTO>> GetAllRLCaseNotifications();

        //RL Agreement
        public Task<ReclaimLossesAgreementDTO> CUDRLAgreement(ReclaimLossesAgreementDTO objDTO);
        //public Task<ReclaimLossesAgreementDTO> CreateRLAgreement(ReclaimLossesAgreementDTO objDTO);
        //public Task<ReclaimLossesAgreementDTO> UpdateRLAgreement(ReclaimLossesAgreementDTO objDTO);
        //public Task<ReclaimLossesAgreementDTO> DeleteRLAgreement(ReclaimLossesAgreementDTO objDTO);
        public Task<ReclaimLossesAgreementDTO> GetRLAgreement(int id);
        public Task<IEnumerable<ReclaimLossesAgreementDTO>> GetAllRLAgreements();

        //RL AgreementNotification
        public Task<ReclaimLossesAgreementNotificationDTO> CUDRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        //public Task<ReclaimLossesAgreementNotificationDTO> CreateRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        //public Task<ReclaimLossesAgreementNotificationDTO> UpdateRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        //public Task<ReclaimLossesAgreementNotificationDTO> DeleteRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO);
        public Task<ReclaimLossesAgreementNotificationDTO> GetRLAgreementNotification(int id);
        public Task<IEnumerable<ReclaimLossesAgreementNotificationDTO>> GetAllRLAgreementNotifications();

        //RL ManualPayment
        public Task<ReclaimLossesManualPaymentDTO> CUDRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        //public Task<ReclaimLossesManualPaymentDTO> CreateRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        //public Task<ReclaimLossesManualPaymentDTO> UpdateRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        //public Task<ReclaimLossesManualPaymentDTO> DeleteRLManualPayment(ReclaimLossesManualPaymentDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLManualPayment();
    }
}
