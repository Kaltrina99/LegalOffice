using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Models
{
    public class ReclaimLossesGetAllCasesResponseDTO
    {
        public int CaseId { get; set; }
        public string CaseNr { get; set; }
        public string AgencyId { get; set; }
        public string EldebitorId { get; set; }
        public string CustomerName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameAL { get; set; }
        public int MainResponsibleUserId { get; set; }
        public string MainResponsibleUser { get; set; }
        public int SecondResponsibleUserId { get; set; }
        public string SecondResponsibleUser { get; set; }
        public string SourceApp { get; set; }
        public int SourceId { get; set; }
        public DateTime SourceDate { get; set; }
        public int CreatedUser { get; set; } //Id
        public string CreatedUserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComment { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusNameAL { get; set; }
        public string LUN { get; set; }
        public DateTime LUD { get; set; }
        public DateTime LUC { get; set; }
        public int TotalCases { get; set; }
    }
}
