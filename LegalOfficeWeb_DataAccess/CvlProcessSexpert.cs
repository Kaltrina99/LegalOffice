using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class CvlProcessSexpert
    {
        public int? ProcessId { get; set; }
        public int? SexpertId { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActiveDate { get; set; }

        public virtual CvlProcess? Process { get; set; }
        public virtual CvlSexpert? Sexpert { get; set; }
    }
}
