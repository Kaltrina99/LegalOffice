using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class AgreementNotificationResponseDTO
    {
        public int Id { get; set; }
        public int AgreementId { get; set; }
        public string NotificationText { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
        public int IsSent { get; set; }
        public DateTime SentDate { get; set; }
        public int ForCustomer { get; set; }
    }
}
