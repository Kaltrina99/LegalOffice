using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlDepartment
    {
        public CvlDepartment()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int CvlDepartmentId { get; set; }
        public string? CvlDepartmentName { get; set; }
        public string? CvlDepartmentNameAl { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
