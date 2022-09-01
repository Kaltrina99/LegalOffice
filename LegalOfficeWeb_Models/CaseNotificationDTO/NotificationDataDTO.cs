using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.CaseNotificationDTO
{
    public class NotificationDataDTO
    {
        public int UserId { get; set; }
        public int CaseId { get; set; }
        public string District { get; set; }
    }
}
