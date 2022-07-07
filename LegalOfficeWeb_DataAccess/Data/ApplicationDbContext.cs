using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApHistory> ApHistories { get; set; } = null!;
        public virtual DbSet<ApMain> ApMains { get; set; } = null!;
        public virtual DbSet<ApStatus> ApStatuses { get; set; } = null!;
        public virtual DbSet<CcDecisionType> CcDecisionTypes { get; set; } = null!;
        public virtual DbSet<CcDetail> CcDetails { get; set; } = null!;
        public virtual DbSet<CcInstanceType> CcInstanceTypes { get; set; } = null!;
        public virtual DbSet<CcMain> CcMains { get; set; } = null!;
        public virtual DbSet<CcPhase> CcPhases { get; set; } = null!;
        public virtual DbSet<CcPhaseType> CcPhaseTypes { get; set; } = null!;
        public virtual DbSet<CcStatus> CcStatuses { get; set; } = null!;
        public virtual DbSet<CvlBasicCourt> CvlBasicCourts { get; set; } = null!;
        public virtual DbSet<CvlDefendantCompany> CvlDefendantCompanies { get; set; } = null!;
        public virtual DbSet<CvlDepartment> CvlDepartments { get; set; } = null!;
        public virtual DbSet<CvlExpert> CvlExperts { get; set; } = null!;
        public virtual DbSet<CvlJudge> CvlJudges { get; set; } = null!;
        public virtual DbSet<CvlLitigationLawyer> CvlLitigationLawyers { get; set; } = null!;
        public virtual DbSet<CvlPlaintiff> CvlPlaintiffs { get; set; } = null!;
        public virtual DbSet<CvlProcess> CvlProcesses { get; set; } = null!;
        public virtual DbSet<CvlProcessDetail> CvlProcessDetails { get; set; } = null!;
        public virtual DbSet<CvlProcessExpert> CvlProcessExperts { get; set; } = null!;
        public virtual DbSet<CvlProcessLog> CvlProcessLogs { get; set; } = null!;
        public virtual DbSet<CvlProcessSexpert> CvlProcessSexperts { get; set; } = null!;
        public virtual DbSet<CvlProcessStatus> CvlProcessStatuses { get; set; } = null!;
        public virtual DbSet<CvlReason> CvlReasons { get; set; } = null!;
        public virtual DbSet<CvlRiskLevel> CvlRiskLevels { get; set; } = null!;
        public virtual DbSet<CvlSexpert> CvlSexperts { get; set; } = null!;
        public virtual DbSet<CvlSubReason> CvlSubReasons { get; set; } = null!;
        public virtual DbSet<RlAgrNatification> RlAgrNatifications { get; set; } = null!;
        public virtual DbSet<RlAgreement> RlAgreements { get; set; } = null!;
        public virtual DbSet<RlAgreementDetail> RlAgreementDetails { get; set; } = null!;
        public virtual DbSet<RlAgrinstallment> RlAgrinstallments { get; set; } = null!;
        public virtual DbSet<RlAgrinvoice> RlAgrinvoices { get; set; } = null!;
        public virtual DbSet<RlCase> RlCases { get; set; } = null!;
        public virtual DbSet<RlCaseDoc> RlCaseDocs { get; set; } = null!;
        public virtual DbSet<RlCaseHistory> RlCaseHistories { get; set; } = null!;
        public virtual DbSet<RlCaseInput> RlCaseInputs { get; set; } = null!;
        public virtual DbSet<RlCaseNatification> RlCaseNatifications { get; set; } = null!;
        public virtual DbSet<RlCaseStatus> RlCaseStatuses { get; set; } = null!;
        public virtual DbSet<RlCasesLog> RlCasesLogs { get; set; } = null!;
        public virtual DbSet<RlCninvoice> RlCninvoices { get; set; } = null!;
        public virtual DbSet<RlDepartment> RlDepartments { get; set; } = null!;
        public virtual DbSet<RlInsType> RlInsTypes { get; set; } = null!;
        public virtual DbSet<RlInvoicePayment> RlInvoicePayments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UsersLog> UsersLogs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApHistory>(entity =>
            {
                entity.ToTable("AP_History");

                entity.Property(e => e.AphistoryId).HasColumnName("APHistoryID");

                entity.Property(e => e.ApmainId).HasColumnName("APMainID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusComment).HasMaxLength(500);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Apmain)
                    .WithMany(p => p.ApHistories)
                    .HasForeignKey(d => d.ApmainId)
                    .HasConstraintName("FK_AP_History_AP_Main");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ApHistories)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_AP_History_AP_Status");
            });

            modelBuilder.Entity<ApMain>(entity =>
            {
                entity.ToTable("AP_Main");

                entity.Property(e => e.ApmainId).HasColumnName("APMainID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("date");
            });

            modelBuilder.Entity<ApStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("AP_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StatusNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("StatusNameAL");
            });

            modelBuilder.Entity<CcDecisionType>(entity =>
            {
                entity.HasKey(e => e.DecisionTypeId);

                entity.ToTable("CC_DecisionType");

                entity.Property(e => e.DecisionTypeId).HasColumnName("DecisionTypeID");

                entity.Property(e => e.DecisionTypeName).HasMaxLength(50);

                entity.Property(e => e.DecisionTypeNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("DecisionTypeNameAL");
            });

            modelBuilder.Entity<CcDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("CC_Details");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.ChargeType).HasMaxLength(50);

                entity.Property(e => e.CourtCaseNr).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfDelivery).HasColumnType("date");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("date");

                entity.Property(e => e.InstanceTypeId).HasColumnName("InstanceTypeID");

                entity.Property(e => e.LegalComment).HasMaxLength(500);

                entity.Property(e => e.LegalName).HasMaxLength(250);

                entity.Property(e => e.LegalPerson).HasMaxLength(250);

                entity.HasOne(d => d.InstanceType)
                    .WithMany(p => p.CcDetails)
                    .HasForeignKey(d => d.InstanceTypeId)
                    .HasConstraintName("FK_CC_Details_CC_InstanceTypes");
            });

            modelBuilder.Entity<CcInstanceType>(entity =>
            {
                entity.HasKey(e => e.InstanceTypeId);

                entity.ToTable("CC_InstanceTypes");

                entity.Property(e => e.InstanceTypeId).HasColumnName("InstanceTypeID");

                entity.Property(e => e.InstanceName).HasMaxLength(50);

                entity.Property(e => e.InstanceNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("InstanceNameAL");
            });

            modelBuilder.Entity<CcMain>(entity =>
            {
                entity.ToTable("CC_Main");

                entity.Property(e => e.CcmainId).HasColumnName("CCMainID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DecisionComment).HasMaxLength(500);

                entity.Property(e => e.DecisionTypeId).HasColumnName("DecisionTypeID");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusComment).HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.DecisionType)
                    .WithMany(p => p.CcMains)
                    .HasForeignKey(d => d.DecisionTypeId)
                    .HasConstraintName("FK_CC_Main_CC_DecisionType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CcMains)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_CC_Main_CC_Status");
            });

            modelBuilder.Entity<CcPhase>(entity =>
            {
                entity.HasKey(e => e.PhaseId);

                entity.ToTable("CC_Phase");

                entity.Property(e => e.PhaseId).HasColumnName("PhaseID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedComment).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PhaseTypeId).HasColumnName("PhaseTypeID");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.ProcessNr).HasMaxLength(50);

                entity.Property(e => e.VerificationDate).HasColumnType("date");

                entity.HasOne(d => d.PhaseType)
                    .WithMany(p => p.CcPhases)
                    .HasForeignKey(d => d.PhaseTypeId)
                    .HasConstraintName("FK_CC_Phase_CC_PhaseTypes");
            });

            modelBuilder.Entity<CcPhaseType>(entity =>
            {
                entity.HasKey(e => e.PhaseTypeId);

                entity.ToTable("CC_PhaseTypes");

                entity.Property(e => e.PhaseTypeId).HasColumnName("PhaseTypeID");

                entity.Property(e => e.PhaseTypeName).HasMaxLength(250);

                entity.Property(e => e.PhaseTypeNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("PhaseTypeNameAL");
            });

            modelBuilder.Entity<CcStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("CC_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StatusNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("StatusNameAL");
            });

            modelBuilder.Entity<CvlBasicCourt>(entity =>
            {
                entity.HasKey(e => e.BasicCourtId);

                entity.ToTable("CVL_BasicCourt");

                entity.Property(e => e.BasicCourtId).HasColumnName("BasicCourtID");

                entity.Property(e => e.BasicCourtName).HasMaxLength(50);
            });

            modelBuilder.Entity<CvlDefendantCompany>(entity =>
            {
                entity.HasKey(e => e.DefendantCompanyId);

                entity.ToTable("CVL_DefendantCompany");

                entity.Property(e => e.DefendantCompanyId).HasColumnName("DefendantCompanyID");

                entity.Property(e => e.DefendantCompanyName).HasMaxLength(50);
            });

            modelBuilder.Entity<CvlDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("CVL_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.DepartmentNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentNameAL");
            });

            modelBuilder.Entity<CvlExpert>(entity =>
            {
                entity.HasKey(e => e.ExpertId);

                entity.ToTable("CVL_Expert");

                entity.Property(e => e.ExpertId).HasColumnName("ExpertID");

                entity.Property(e => e.ExpertName).HasMaxLength(50);
            });

            modelBuilder.Entity<CvlJudge>(entity =>
            {
                entity.HasKey(e => e.JudgeId);

                entity.ToTable("CVL_Judge");

                entity.Property(e => e.JudgeId).HasColumnName("JudgeID");

                entity.Property(e => e.JudgeName).HasMaxLength(50);
            });

            modelBuilder.Entity<CvlLitigationLawyer>(entity =>
            {
                entity.HasKey(e => e.LitigationLawyerId);

                entity.ToTable("CVL_litigationLawyer");

                entity.Property(e => e.LitigationLawyerId).HasColumnName("litigationLawyerID");

                entity.Property(e => e.LitigationLawyerName)
                    .HasMaxLength(50)
                    .HasColumnName("litigationLawyerName");
            });

            modelBuilder.Entity<CvlPlaintiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_Plaintiff");

                entity.Property(e => e.PfIsDeleted).HasColumnName("PF_IsDeleted");

                entity.Property(e => e.PlaintBusinessNr).HasMaxLength(50);

                entity.Property(e => e.PlaintiffIdentityNr).HasMaxLength(50);

                entity.Property(e => e.PlaintiffName).HasMaxLength(250);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.HasOne(d => d.Process)
                    .WithMany()
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_CVL_Plaintiff_CVL_Process");
            });

            modelBuilder.Entity<CvlProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("CVL_Process");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.BasicCourtId).HasColumnName("BasicCourtID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefendantCompanyId).HasColumnName("DefendantCompanyID");

                entity.Property(e => e.DeletedComment).HasMaxLength(250);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.JudgeId).HasColumnName("JudgeID");

                entity.Property(e => e.LastProcessStatusId).HasColumnName("LastProcessStatusID");

                entity.Property(e => e.LastStatusComment).HasMaxLength(2500);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.LitigationLawyerId).HasColumnName("litigationLawyerID");

                entity.Property(e => e.OldProcessId).HasColumnName("OldProcessID");

                entity.Property(e => e.ProcessCaseNumber).HasMaxLength(250);

                entity.Property(e => e.ProcessComment).HasMaxLength(2500);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessValue).HasColumnType("money");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.RiskLevelId).HasColumnName("RiskLevelID");

                entity.Property(e => e.SubReasonId).HasColumnName("SubReasonID");

                entity.HasOne(d => d.BasicCourt)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.BasicCourtId)
                    .HasConstraintName("FK_CVL_Process_CVL_BasicCourt");

                entity.HasOne(d => d.DefendantCompany)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.DefendantCompanyId)
                    .HasConstraintName("FK_CVL_Process_CVL_DefendantCompany");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_CVL_Process_CVL_Department");

                entity.HasOne(d => d.Judge)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.JudgeId)
                    .HasConstraintName("FK_CVL_Process_CVL_Judge");

                entity.HasOne(d => d.LitigationLawyer)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.LitigationLawyerId)
                    .HasConstraintName("FK_CVL_Process_CVL_litigationLawyer");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK_CVL_Process_CVL_Reason");

                entity.HasOne(d => d.RiskLevel)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.RiskLevelId)
                    .HasConstraintName("FK_CVL_Process_CVL_RiskLevel");

                entity.HasOne(d => d.SubReason)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.SubReasonId)
                    .HasConstraintName("FK_CVL_Process_CVL_SubReason");
            });

            modelBuilder.Entity<CvlProcessDetail>(entity =>
            {
                entity.HasKey(e => e.ProcessDetailId)
                    .HasName("PK_CLV_ProcessDetail");

                entity.ToTable("CVL_ProcessDetail");

                entity.Property(e => e.ProcessDetailId).HasColumnName("ProcessDetailID");

                entity.Property(e => e.CaseFinishedAmount).HasColumnType("money");

                entity.Property(e => e.FinishedKedsdebitor).HasColumnName("FinishedKEDSDebitor");

                entity.Property(e => e.PdCreatedComment)
                    .HasMaxLength(2500)
                    .HasColumnName("PD_CreatedComment");

                entity.Property(e => e.PdCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PD_CreatedDate");

                entity.Property(e => e.PdCreatedUser).HasColumnName("PD_CreatedUser");

                entity.Property(e => e.PdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PD_Date");

                entity.Property(e => e.PdDeleted).HasColumnName("PD_Deleted");

                entity.Property(e => e.PdDeletedComment)
                    .HasMaxLength(250)
                    .HasColumnName("PD_DeletedComment");

                entity.Property(e => e.PdDeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PD_DeletedDate");

                entity.Property(e => e.PdDeletedUser).HasColumnName("PD_DeletedUser");

                entity.Property(e => e.PdDocumentPath)
                    .HasMaxLength(250)
                    .HasColumnName("PD_DocumentPath");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessStatusId).HasColumnName("ProcessStatusID");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.CvlProcessDetails)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_CLV_ProcessDetail_CVL_Process");

                entity.HasOne(d => d.ProcessStatus)
                    .WithMany(p => p.CvlProcessDetails)
                    .HasForeignKey(d => d.ProcessStatusId)
                    .HasConstraintName("FK_CLV_ProcessDetail_CVL_ProcessStatus");
            });

            modelBuilder.Entity<CvlProcessExpert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_ProcessExpert");

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpertId).HasColumnName("ExpertID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.HasOne(d => d.Expert)
                    .WithMany()
                    .HasForeignKey(d => d.ExpertId)
                    .HasConstraintName("FK_CVL_ProcessExpert_CVL_Expert");

                entity.HasOne(d => d.Process)
                    .WithMany()
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_CVL_ProcessExpert_CVL_Process");
            });

            modelBuilder.Entity<CvlProcessLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_ProcessLog");

                entity.Property(e => e.BasicCourtId).HasColumnName("BasicCourtID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefendantCompanyId).HasColumnName("DefendantCompanyID");

                entity.Property(e => e.DeletedComment).HasMaxLength(250);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.JudgeId).HasColumnName("JudgeID");

                entity.Property(e => e.LastProcessStatusId).HasColumnName("LastProcessStatusID");

                entity.Property(e => e.LastStatusComment).HasMaxLength(2500);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.LitigationLawyerId).HasColumnName("litigationLawyerID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.LogUserId).HasColumnName("LogUserID");

                entity.Property(e => e.ProcessCaseNumber).HasMaxLength(250);

                entity.Property(e => e.ProcessComment).HasMaxLength(2500);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessValue).HasColumnType("money");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.RiskLevelId).HasColumnName("RiskLevelID");

                entity.Property(e => e.SubReasonId).HasColumnName("SubReasonID");
            });

            modelBuilder.Entity<CvlProcessSexpert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_ProcessSExpert");

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.SexpertId).HasColumnName("SExpertID");

                entity.HasOne(d => d.Process)
                    .WithMany()
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_CVL_ProcessSExpert_CVL_Process");

                entity.HasOne(d => d.Sexpert)
                    .WithMany()
                    .HasForeignKey(d => d.SexpertId)
                    .HasConstraintName("FK_CVL_ProcessSExpert_CVL_SExpert");
            });

            modelBuilder.Entity<CvlProcessStatus>(entity =>
            {
                entity.HasKey(e => e.ProcessStatusId);

                entity.ToTable("CVL_ProcessStatus");

                entity.Property(e => e.ProcessStatusId).HasColumnName("ProcessStatusID");

                entity.Property(e => e.ProcessStatusName).HasMaxLength(250);

                entity.Property(e => e.ProcessStatusNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("ProcessStatusNameAL");
            });

            modelBuilder.Entity<CvlReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("CVL_Reason");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.ReasonName).HasMaxLength(250);

                entity.Property(e => e.ReasonNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("ReasonNameAL");
            });

            modelBuilder.Entity<CvlRiskLevel>(entity =>
            {
                entity.HasKey(e => e.RiskLevelId);

                entity.ToTable("CVL_RiskLevel");

                entity.Property(e => e.RiskLevelId).HasColumnName("RiskLevelID");

                entity.Property(e => e.RiskLevelName).HasMaxLength(50);
            });

            modelBuilder.Entity<CvlSexpert>(entity =>
            {
                entity.HasKey(e => e.SexpertId);

                entity.ToTable("CVL_SExpert");

                entity.Property(e => e.SexpertId).HasColumnName("SExpertID");

                entity.Property(e => e.SexpertName)
                    .HasMaxLength(50)
                    .HasColumnName("SExpertName");
            });

            modelBuilder.Entity<CvlSubReason>(entity =>
            {
                entity.HasKey(e => e.SubReasonId);

                entity.ToTable("CVL_SubReason");

                entity.Property(e => e.SubReasonId).HasColumnName("SubReasonID");

                entity.Property(e => e.SubReasonName).HasMaxLength(250);

                entity.Property(e => e.SubReasonNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("SubReasonNameAL");
            });

            modelBuilder.Entity<RlAgrNatification>(entity =>
            {
                entity.ToTable("RL_AgrNatification");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.RlAgrNatifications)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_RL_AgrNatification_RL_Agreement");
            });

            modelBuilder.Entity<RlAgreement>(entity =>
            {
                entity.HasKey(e => e.AgreementId);

                entity.ToTable("RL_Agreement");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedComment).HasMaxLength(2000);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.RlAgreements)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_RL_Agreement_RL_Cases");
            });

            modelBuilder.Entity<RlAgreementDetail>(entity =>
            {
                entity.HasKey(e => e.AgdetailId);

                entity.ToTable("RL_AgreementDetail");

                entity.Property(e => e.AgdetailId).HasColumnName("AGDetailID");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CridentityNr)
                    .HasMaxLength(20)
                    .HasColumnName("CRIdentityNr");

                entity.Property(e => e.CrphoneNr)
                    .HasMaxLength(20)
                    .HasColumnName("CRPhoneNr");

                entity.Property(e => e.CusAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.CustomerRepresentative).HasMaxLength(250);

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.IdentityNr).HasMaxLength(20);

                entity.Property(e => e.PhoneNr).HasMaxLength(20);

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.RlAgreementDetails)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_RL_AgreementDetail_RL_Agreement");
            });

            modelBuilder.Entity<RlAgrinstallment>(entity =>
            {
                entity.HasKey(e => e.AgrInsId);

                entity.ToTable("RL_AGRInstallment");

                entity.Property(e => e.AgrInsId).HasColumnName("AgrInsID");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.InsTypeId).HasColumnName("InsTypeID");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.RlAgrinstallments)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_RL_AGRInstallment_RL_Agreement");

                entity.HasOne(d => d.InsType)
                    .WithMany(p => p.RlAgrinstallments)
                    .HasForeignKey(d => d.InsTypeId)
                    .HasConstraintName("FK_RL_AGRInstallment_RL_InsTypes");
            });

            modelBuilder.Entity<RlAgrinvoice>(entity =>
            {
                entity.ToTable("RL_AGRInvoices");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceAmountInv).HasColumnType("money");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceIdccp).HasColumnName("InvoiceIDCCP");

                entity.Property(e => e.InvoiceIdrl).HasColumnName("InvoiceIDRL");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.RlAgrinvoices)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_RL_AGRInvoices_RL_Agreement");
            });

            modelBuilder.Entity<RlCase>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("RL_Cases");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.CaseNr).HasMaxLength(50);

                entity.Property(e => e.CreatedComment).HasMaxLength(2500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.DeletedComment).HasMaxLength(2500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.MainResponsibleUserId).HasColumnName("MainResponsibleUserID");

                entity.Property(e => e.SecondResponsibleUserId).HasColumnName("SecondResponsibleUserID");

                entity.Property(e => e.SourceApp).HasMaxLength(50);

                entity.Property(e => e.SourceDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.RlCases)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_RL_Cases_RL_Department");
            });

            modelBuilder.Entity<RlCaseDoc>(entity =>
            {
                entity.HasKey(e => e.CaseDocId);

                entity.ToTable("RL_CaseDoc");

                entity.Property(e => e.CaseDocId).HasColumnName("CaseDocID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocName).HasMaxLength(250);

                entity.Property(e => e.DocPath).HasMaxLength(250);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.RlCaseDocs)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_RL_CaseDoc_RL_Cases");
            });

            modelBuilder.Entity<RlCaseHistory>(entity =>
            {
                entity.HasKey(e => e.CaseHistoryId);

                entity.ToTable("RL_CaseHistory");

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedComment).HasMaxLength(2500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedComment).HasMaxLength(2500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.RlCaseHistories)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_RL_CaseHistory_RL_Cases");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RlCaseHistories)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_RL_CaseHistory_RL_CaseStatus");
            });

            modelBuilder.Entity<RlCaseInput>(entity =>
            {
                entity.HasKey(e => e.CaseIputId);

                entity.ToTable("RL_CaseInputs");

                entity.Property(e => e.CaseIputId).HasColumnName("CaseIputID");

                entity.Property(e => e.Address).HasMaxLength(2500);

                entity.Property(e => e.AmeterId).HasColumnName("AMeterID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IdentityNr).HasMaxLength(20);

                entity.Property(e => e.Municipality).HasMaxLength(50);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.Property(e => e.Subdistrict).HasMaxLength(250);

                entity.Property(e => e.TariffId)
                    .HasMaxLength(10)
                    .HasColumnName("TariffID");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.RlCaseInputs)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_RL_CaseInputs_RL_Cases");
            });

            modelBuilder.Entity<RlCaseNatification>(entity =>
            {
                entity.HasKey(e => e.Cnid);

                entity.ToTable("RL_CaseNatifications");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.HasOne(d => d.CaseHistory)
                    .WithMany(p => p.RlCaseNatifications)
                    .HasForeignKey(d => d.CaseHistoryId)
                    .HasConstraintName("FK_RL_CaseNatifications_RL_CaseHistory");
            });

            modelBuilder.Entity<RlCaseStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("RL_CaseStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StatusNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("StatusNameAL");
            });

            modelBuilder.Entity<RlCasesLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RL_CasesLog");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseNr).HasMaxLength(50);

                entity.Property(e => e.CreatedComment).HasMaxLength(2500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.DeletedComment).HasMaxLength(2500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogUserId).HasColumnName("LogUserID");

                entity.Property(e => e.MainResponsibleUserId).HasColumnName("MainResponsibleUserID");

                entity.Property(e => e.SecondResponsibleUserId).HasColumnName("SecondResponsibleUserID");

                entity.Property(e => e.SourceApp).HasMaxLength(50);

                entity.Property(e => e.SourceDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<RlCninvoice>(entity =>
            {
                entity.ToTable("RL_CNInvoices");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceAmountInv).HasColumnType("money");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceIdccp).HasColumnName("InvoiceIDCCP");

                entity.Property(e => e.InvoiceIdrl)
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceIDRL");

                entity.HasOne(d => d.Cn)
                    .WithMany(p => p.RlCninvoices)
                    .HasForeignKey(d => d.Cnid)
                    .HasConstraintName("FK_RL_CNInvoices_RL_CaseNatifications");
            });

            modelBuilder.Entity<RlDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("RL_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.DepartmentNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentNameAL");

                entity.Property(e => e.Modules).HasMaxLength(250);
            });

            modelBuilder.Entity<RlInsType>(entity =>
            {
                entity.HasKey(e => e.InsTypeId);

                entity.ToTable("RL_InsTypes");

                entity.Property(e => e.InsTypeId).HasColumnName("InsTypeID");

                entity.Property(e => e.InsTypeName).HasMaxLength(50);

                entity.Property(e => e.InsTypeNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("InsTypeNameAL");
            });

            modelBuilder.Entity<RlInvoicePayment>(entity =>
            {
                entity.ToTable("RL_InvoicePayments");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.ArchiveId).HasColumnName("ArchiveID");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CreatedComment).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.CreditInv).HasColumnType("money");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.RlInvoicePayments)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_RL_InvoicePayments_RL_Agreement");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.RoleNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("RoleNameAL");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.BlockedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainRoleId).HasColumnName("MainRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_Users");
            });

            modelBuilder.Entity<UsersLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsersLog");

                entity.Property(e => e.BlockedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogUserId).HasColumnName("LogUserID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
