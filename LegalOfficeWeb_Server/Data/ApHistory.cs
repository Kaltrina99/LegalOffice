using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_Server.Data
{
    public partial class ApHistory
    {
        public int AphistoryId { get; set; }
        public int? ApmainId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? StatusComment { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }

        public virtual ApMain? Apmain { get; set; }
        public virtual ApStatus? Status { get; set; }
    }
}
