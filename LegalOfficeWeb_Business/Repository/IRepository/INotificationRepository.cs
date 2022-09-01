using LegalOfficeWeb_Models.CaseNotificationDTO;
using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationResponseDTO = LegalOfficeWeb_Models.CaseNotificationDTO.NotificationResponseDTO;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface INotificationRepository
    {
        public Task<NotificationResponseDTO> CUDRLCaseNotification(CUDNotificationDTO objDTO);
        public Task<NotificationResponseDTO> GetRLCaseNotification(NotificationDataDTO objDTO);
        public Task<NotificationInvoiceDTO> GetRLCaseNotificationInvioce(NotificationDataDTO objDTO);
    }
}
