using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesCaseResponseDTO
    {
        public int? CaseId { get; set; }
        public string? CaseNr { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public string? Subdistrict { get; set; }
        public string? CustomerName { get; set; }
        public string? IdentityNr { get; set; }
        public int? AMeterId { get; set; }
        public string? PhoneNr { get; set; }
        public string? Address { get; set; }
        public int? DepartmentId { get; set; }
        public int? MainResponsibleUserId { get; set; }
        public int? SecondResponsibleUserId { get; set; }
        public string? SourceApp { get; set; }
        public int? SourceId { get; set; }
        public string? SourceDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public string? CreatedComment { get; set; }
        public string? StatusName { get; set; }
        public string? StatusNameAL { get; set; }
    }
}
