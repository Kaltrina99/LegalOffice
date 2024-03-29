﻿using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlInsType
    {
        public RlInsType()
        {
            RlAgrInstallments = new HashSet<RlAgrInstallment>();
        }

        public int InsTypeId { get; set; }
        public string? InsTypeName { get; set; }
        public string? InsTypeNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RlAgrInstallment> RlAgrInstallments { get; set; }
    }
}
