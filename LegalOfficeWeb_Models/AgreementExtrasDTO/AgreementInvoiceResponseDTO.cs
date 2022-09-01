using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class AgreementInvoiceResponseDTO
    {
        public int Id { get; set; }
        public int AgreementId { get; set; }
        public int CaseId { get; set; }
        public int AgencyId { get; set; }
        public int EldebitorId { get; set; }
        public int InvoiceId { get; set; }
        public int InvoiceIdccp { get; set; }
        public int InvoiceIdrl { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceAmountInv { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
    }
}
