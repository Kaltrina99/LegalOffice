using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class AgreemeentInvoicePaymentsResponseDTO
    {
        public int Id { get; set; }
        public int AgreementId { get; set; }
        public int InvoiceId { get; set; }
        public int CollectionID { get; set; }
        public int ArchiveID { get; set; }
        public double Credit { get; set; }
        public string CreditInv { get; set; }
        public int CreatedUser { get; set; }
        public int IsSent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComment { get; set; }
        public string DocumentPath { get; set; }
        public string CreatedUserName { get; set; }
    }
}
