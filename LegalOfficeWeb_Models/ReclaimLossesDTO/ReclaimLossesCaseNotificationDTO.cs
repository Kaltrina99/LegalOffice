using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesCaseNotificationDTO
    {
        public int? UserId { get; set; }
        public int? CaseId { get; set; }
        public int? CaseHistoryID { get; set; }
        public string? CreatedComment { get; set; }
        public string? CustomerName { get; set; }
        public string? IdentityNr { get; set; }
        public string? PhoneNr { get; set; }
        public int? WaitingDay { get; set; }
        public string? InvoiceIDs { get; set; }
        public int? ProcessType { get; set; }
    }
}
