using System;
using System.Collections.Generic;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class CvlProcessDetail
    {
        public int CvlProcessDetailId { get; set; }
        public int? CvlProcessId { get; set; }
        public int? CvlProcessStatusId { get; set; }
        public DateTime? CvlPdDate { get; set; }
        public DateTime? CvlPdCreateDate { get; set; }
        public int? CvlPdCreateUserId { get; set; }
        public string? CvlPdCreateComment { get; set; }
        public string? CvlPdDocumentPath { get; set; }
        public bool? CvlPdIsDeleted { get; set; }
        public int? CvlPdIsDeletedUserId { get; set; }
        public DateTime? CvlPdIsDeletedDate { get; set; }
        public string? CvlPdIsDeletedComment { get; set; }
        public decimal? CvlCaseFinishedAmount { get; set; }
        public int? CvlFinishedKedsdebitor { get; set; }

        public virtual CvlProcess? CvlProcess { get; set; }
        public virtual CvlProcessStatus? CvlProcessStatus { get; set; }
    }
}
