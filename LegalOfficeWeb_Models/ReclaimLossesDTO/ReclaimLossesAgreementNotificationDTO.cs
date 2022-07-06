using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesAgreementNotificationDTO
    {
        public int? UserId { get; set; }
        public int? NotificationID { get; set; }
        public int? AgreementID { get; set; }
        public string? NotificationText { get; set; }
        public string? PhoneNr { get; set; }
        public string? Email { get; set; }
        public int? ForCustomer { get; set; }
        public int? IsSent { get; set; }
        public int? ProcessType { get; set; }
    }
}
