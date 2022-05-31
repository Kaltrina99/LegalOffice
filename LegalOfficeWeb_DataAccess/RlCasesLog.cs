using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess
{
    public partial class RlCasesLog
    {
        public int? CaseId { get; set; }
        public string? CaseNr { get; set; }
        public string? AgencyId { get; set; }
        public int? EldebitorId { get; set; }
        public string? CustomerName { get; set; }
        public int? DepartmentId { get; set; }
        public int? MainResponsibleUserId { get; set; }
        public int? SecondResponsibleUserId { get; set; }
        public string? SourceApp { get; set; }
        public int? SourceId { get; set; }
        public DateTime? SourceDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedComment { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }
        public int? LogUserId { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
