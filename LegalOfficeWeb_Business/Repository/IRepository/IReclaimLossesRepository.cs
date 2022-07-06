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
        public Task<ReclaimLossesCaseDTO> CreateRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLCase(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLCase(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLCases(int? id = null);

        //RL CaseHistory
        public Task<ReclaimLossesCaseHistoryDTO> CreateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<ReclaimLossesCaseHistoryDTO> UpdateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<ReclaimLossesCaseHistoryDTO> DeleteRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO);
        public Task<ReclaimLossesCaseHistoryDTO> GetRLCaseHistory(int id);
        public Task<IEnumerable<ReclaimLossesCaseHistoryDTO>> GetAllRLCaseHistories(int? id = null);

        //RL CaseNotification
        public Task<ReclaimLossesCaseDTO> CreateRLCaseNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLCaseNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLCaseNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLCaseNotification(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLCaseNotifications(int? id = null);

        //RL Agreement
        public Task<ReclaimLossesCaseDTO> CreateRLAgreement(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLAgreement(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLAgreement(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLAgreement(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLAgreements(int? id = null);

        //RL AgreementNotification
        public Task<ReclaimLossesCaseDTO> CreateRLAgreementNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLAgreementNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLAgreementNotification(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLAgreementNotification(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLAgreementNotifications(int? id = null);

        //RL ManualPayment
        public Task<ReclaimLossesCaseDTO> CreateRLManualPayment(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> UpdateRLManualPayment(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> DeleteRLManualPayment(ReclaimLossesCaseDTO objDTO);
        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id);
        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLManualPayment(int? id = null);
    }
}
