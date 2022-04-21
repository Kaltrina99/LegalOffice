using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlProcess
    {
        public CvlProcess()
        {
            CvlProcessDetails = new HashSet<CvlProcessDetail>();
        }

        public int CvlProcessId { get; set; }
        public string? CvlProcessPlaintiffName { get; set; }
        public int? CvlDefendantCompanyId { get; set; }
        public int? CvlDepartmentId { get; set; }
        public int? CvlReasonId { get; set; }
        public int? CvlSubReasonId { get; set; }
        public int? CvlBasicCourtId { get; set; }
        public int? CvlJudgeId { get; set; }
        public string? CvlExpertIds { get; set; }
        public string? CvlSexpertIds { get; set; }
        public int? CvlRiskLevelId { get; set; }
        public int? CvlLitigationLawyerId { get; set; }
        public string? CvlProcessCaseNumber { get; set; }
        public decimal? CvlProcessValue { get; set; }
        public DateTime? CvlEventDate { get; set; }
        public DateTime? CvlProcessDate { get; set; }
        public string? CvlProcessComment { get; set; }
        public int? CvlLastProcessStatusId { get; set; }
        public DateTime? CvlLastStatusDate { get; set; }
        public string? CvlLastStatusComment { get; set; }
        public DateTime? CvlCreateDate { get; set; }
        public int? CvlCreateUserId { get; set; }
        public bool? CvlIsDeleted { get; set; }
        public int? CvlIsDeletedUserId { get; set; }
        public DateTime? CvlIsDeletedDate { get; set; }
        public string? CvlIsDeletedComment { get; set; }
        public bool? CvlIsFinished { get; set; }

        public virtual CvlBasicCourt? CvlBasicCourt { get; set; }
        public virtual CvlDefendantCompany? CvlDefendantCompany { get; set; }
        public virtual CvlDepartment? CvlDepartment { get; set; }
        public virtual CvlJudge? CvlJudge { get; set; }
        public virtual CvlReason? CvlReason { get; set; }
        public virtual CvlRiskLevel? CvlRiskLevel { get; set; }
        public virtual CvlSubReason? CvlSubReason { get; set; }
        public virtual ICollection<CvlProcessDetail> CvlProcessDetails { get; set; }
    }
}
