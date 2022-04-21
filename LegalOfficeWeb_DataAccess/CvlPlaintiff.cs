using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlPlaintiff
    {
        public int? CvlProcessId { get; set; }
        public string? CvlPlaintiffName { get; set; }
        public string? CvlPlaintiffIdentityNr { get; set; }
        public string? CvlPlaintBusinessNr { get; set; }
        public bool? CvlPfIsDeleted { get; set; }

        public virtual CvlProcess? CvlProcess { get; set; }
    }
}
