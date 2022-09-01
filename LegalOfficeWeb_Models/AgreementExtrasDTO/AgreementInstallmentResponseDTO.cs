using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models.AgreementExtrasDTO
{
    public class AgreementInstallmentResponseDTO
    {
        public int AgrInsId { get; set; }
        public int AgreementId { get; set; }
        public int CaseId { get; set; }
        public decimal Amount { get; set; }
        public int InsNo { get; set; }
        public int InsTypeId { get; set; }
        public DateTime DueDate { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserName { get; set; }
    }
}
