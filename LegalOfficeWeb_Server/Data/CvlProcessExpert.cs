using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlProcessExpert
    {
        public int? ProcessId { get; set; }
        public int? ExpertId { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActiveDate { get; set; }

        public virtual CvlExpert? Expert { get; set; }
        public virtual CvlProcess? Process { get; set; }
    }
}
