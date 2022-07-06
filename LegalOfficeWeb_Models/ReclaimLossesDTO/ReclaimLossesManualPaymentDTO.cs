using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesManualPaymentDTO
    {
        public int? UserId { get; set; }
        public int? PaymentId { get; set; }
        public int? AgreementId { get; set; }
        public int? InvoiceId { get; set; }
        public int? CollectionId { get; set; }
        public double? Credit { get; set; }
        public string? Comment { get; set; }
        public string? DocName { get; set; }
        public int? ProcessType { get; set; }
    }
}
