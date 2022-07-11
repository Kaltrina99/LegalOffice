﻿using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlReason
    {
        public CvlReason()
        {
            CvlProcesses = new HashSet<CvlProcess>();
        }

        public int ReasonId { get; set; }
        public string? ReasonName { get; set; }
        public string? ReasonNameAl { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CvlProcess> CvlProcesses { get; set; }
    }
}
