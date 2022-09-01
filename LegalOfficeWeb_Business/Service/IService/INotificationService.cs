using LegalOfficeWeb_Models.CaseNotificationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface INotificationService
    {
        public Task<NotificationResponseDTO> CUDRLCaseNotification(CUDNotificationDTO objDTO);
        public Task<NotificationResponseDTO> GetRLCaseNotification(NotificationDataDTO objDTO);
        public Task<NotificationInvoiceDTO> GetRLCaseNotificationInvioce(NotificationDataDTO objDTO);
    }
}
