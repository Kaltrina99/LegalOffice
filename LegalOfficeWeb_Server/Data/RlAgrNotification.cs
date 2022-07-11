using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class RlAgrNotification
    {
        public int Id { get; set; }
        public int? AgreementId { get; set; }
        public string? NotificationText { get; set; }
        public string? PhoneNr { get; set; }
        public string? Email { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsSent { get; set; }
        public DateTime? SentDate { get; set; }
        public bool? ForCustomer { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
    }
}
