using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlInsType
    {
        public RlInsType()
        {
            RlAgrinstallments = new HashSet<RlAgrinstallment>();
        }

        public int InsTypeId { get; set; }
        public string? InsTypeName { get; set; }
        public string? InsTypeNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RlAgrinstallment> RlAgrinstallments { get; set; }
    }
}
