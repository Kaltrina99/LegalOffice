using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlProcessLog
    {
        public int? ProcessId { get; set; }
        public int? DefendantCompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ReasonId { get; set; }
        public int? SubReasonId { get; set; }
        public int? BasicCourtId { get; set; }
        public int? JudgeId { get; set; }
        public int? RiskLevelId { get; set; }
        public int? LitigationLawyerId { get; set; }
        public string? ProcessCaseNumber { get; set; }
        public decimal? ProcessValue { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? ProcessComment { get; set; }
        public int? LastProcessStatusId { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public string? LastStatusComment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public bool? Deleted { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedComment { get; set; }
        public int? LogUserId { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
