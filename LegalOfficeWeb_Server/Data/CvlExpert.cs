﻿using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class CvlExpert
    {
        public int ExpertId { get; set; }
        public string? ExpertName { get; set; }
        public bool? Active { get; set; }
    }
}