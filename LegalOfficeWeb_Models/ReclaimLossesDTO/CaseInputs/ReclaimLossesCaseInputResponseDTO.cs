using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesCaseInputResponseDTO
    {
        public int CaseInputId { get; set; }
        public int CaseId { get; set; }
        public string Subdistrict { get; set; }
        public int AMeterID { get; set; }
        public string TariffId { get; set; }
        public string IdentityNr { get; set; }
        public string PhoneNr { get; set; }
        public string Address { get; set; }
        public string? Municipality { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
