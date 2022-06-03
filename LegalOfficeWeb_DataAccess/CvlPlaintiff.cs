using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlPlaintiff
    {
        public int? ProcessId { get; set; }
        public string? PlaintiffName { get; set; }
        public string? PlaintiffIdentityNr { get; set; }
        public string? PlaintBusinessNr { get; set; }
        public bool? PfIsDeleted { get; set; }

        public virtual CvlProcess? Process { get; set; }
    }
}
