using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.CaseNotificationDTO
{
    public class NotificationResponseDTO
    {
        public int Cnid { get; set; }
        public int? CaseHistoryId { get; set; }
        public int? CaseId { get; set; }
        public string? CustomerName { get; set; }
        public int? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public int? WaitingDays { get; set; }
        public string? DocumentPath { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
