using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class CUDAgreementNotificationDTO
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public int AgreementId { get; set; }
        public string NotificationText { get; set; }
        public string PhonrNr { get; set; }
        public string Email { get; set; }
        public int ForCustomer { get; set; }
        public int IsSent { get; set; }
        public int ProcessType { get; set; } //1=insert, 2=update, 3=delete, 4=sent
    }
}
