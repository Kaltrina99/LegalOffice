﻿using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class RlAgrInstallment
    {
        public int AgrInsId { get; set; }
        public int? AgreementId { get; set; }
        public int? CaseId { get; set; }
        public decimal? Amount { get; set; }
        public int? InsNo { get; set; }
        public int? InsTypeId { get; set; }
        public DateTime? DueDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Active { get; set; }

        public virtual RlAgreement? Agreement { get; set; }
        public virtual RlInsType? InsType { get; set; }
    }
}
