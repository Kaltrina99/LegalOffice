using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class RlDepartment
    {
        public RlDepartment()
        {
            RlCases = new HashSet<RlCase>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentNameAl { get; set; }
        public bool? Active { get; set; }
        public string? Modules { get; set; }

        public virtual ICollection<RlCase> RlCases { get; set; }
    }
}
