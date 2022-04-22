using LegalOfficeWeb_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_DataAccess.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<CvlBasicCourt> CvlBasicCourts { get; set; } = null!;
        public virtual DbSet<CvlDefendantCompany> CvlDefendantCompanies { get; set; } = null!;
        public virtual DbSet<CvlDepartment> CvlDepartments { get; set; } = null!;
        public virtual DbSet<CvlExpert> CvlExperts { get; set; } = null!;
        public virtual DbSet<CvlJudge> CvlJudges { get; set; } = null!;
        public virtual DbSet<CvlLitigationLawyer> CvlLitigationLawyers { get; set; } = null!;
        public virtual DbSet<CvlPlaintiff> CvlPlaintiffs { get; set; } = null!;
        public virtual DbSet<CvlProcess> CvlProcesses { get; set; } = null!;
        public virtual DbSet<CvlProcessDetail> CvlProcessDetails { get; set; } = null!;
        public virtual DbSet<CvlProcessLog> CvlProcessLogs { get; set; } = null!;
        public virtual DbSet<CvlProcessStatus> CvlProcessStatuses { get; set; } = null!;
        public virtual DbSet<CvlReason> CvlReasons { get; set; } = null!;
        public virtual DbSet<CvlRiskLevel> CvlRiskLevels { get; set; } = null!;
        public virtual DbSet<CvlSexpert> CvlSexperts { get; set; } = null!;
        public virtual DbSet<CvlSubReason> CvlSubReasons { get; set; } = null!;
        public virtual DbSet<RlAgrNatification> RlAgrNatifications { get; set; } = null!;
        public virtual DbSet<RlAgreement> RlAgreements { get; set; } = null!;
        public virtual DbSet<RlAgrinstallment> RlAgrinstallments { get; set; } = null!;
        public virtual DbSet<RlAgrinvoice> RlAgrinvoices { get; set; } = null!;
        public virtual DbSet<RlCase> RlCases { get; set; } = null!;
        public virtual DbSet<RlCaseHistory> RlCaseHistories { get; set; } = null!;
        public virtual DbSet<RlCaseNatification> RlCaseNatifications { get; set; } = null!;
        public virtual DbSet<RlCaseStatus> RlCaseStatuses { get; set; } = null!;
        public virtual DbSet<RlCninvoice> RlCninvoices { get; set; } = null!;
        public virtual DbSet<RlInsType> RlInsTypes { get; set; } = null!;
        public virtual DbSet<RlInvoicePayment> RlInvoicePayments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{ 
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HammurabiDB;Trusted_Connection=true");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CvlBasicCourt>(entity =>
            {
                entity.ToTable("CVL_BasicCourt");

                entity.Property(e => e.CvlBasicCourtId).HasColumnName("CVL_BasicCourtID");

                entity.Property(e => e.CvlBasicCourtName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_BasicCourtName");
            });

            modelBuilder.Entity<CvlDefendantCompany>(entity =>
            {
                entity.ToTable("CVL_DefendantCompany");

                entity.Property(e => e.CvlDefendantCompanyId).HasColumnName("CVL_DefendantCompanyID");

                entity.Property(e => e.CvlDefendantCompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_DefendantCompanyName");
            });

            modelBuilder.Entity<CvlDepartment>(entity =>
            {
                entity.ToTable("CVL_Department");

                entity.Property(e => e.CvlDepartmentId).HasColumnName("CVL_DepartmentID");

                entity.Property(e => e.CvlDepartmentName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_DepartmentName");

                entity.Property(e => e.CvlDepartmentNameAl)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_DepartmentNameAL");
            });

            modelBuilder.Entity<CvlExpert>(entity =>
            {
                entity.ToTable("CVL_Expert");

                entity.Property(e => e.CvlExpertId).HasColumnName("CVL_ExpertID");

                entity.Property(e => e.CvlExpertName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_ExpertName");
            });

            modelBuilder.Entity<CvlJudge>(entity =>
            {
                entity.ToTable("CVL_Judge");

                entity.Property(e => e.CvlJudgeId).HasColumnName("CVL_JudgeID");

                entity.Property(e => e.CvlJudgeName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_JudgeName");
            });

            modelBuilder.Entity<CvlLitigationLawyer>(entity =>
            {
                entity.ToTable("CVL_litigationLawyer");

                entity.Property(e => e.CvlLitigationLawyerId).HasColumnName("CVL_litigationLawyerID");

                entity.Property(e => e.CvlLitigationLawyerName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_litigationLawyerName");
            });

            modelBuilder.Entity<CvlPlaintiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_Plaintiff");

                entity.Property(e => e.CvlPfIsDeleted).HasColumnName("CVL_PF_IsDeleted");

                entity.Property(e => e.CvlPlaintBusinessNr)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_PlaintBusinessNr");

                entity.Property(e => e.CvlPlaintiffIdentityNr)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_PlaintiffIdentityNr");

                entity.Property(e => e.CvlPlaintiffName)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_PlaintiffName");

                entity.Property(e => e.CvlProcessId).HasColumnName("CVL_ProcessID");

                entity.HasOne(d => d.CvlProcess)
                    .WithMany()
                    .HasForeignKey(d => d.CvlProcessId)
                    .HasConstraintName("FK_CVL_Plaintiff_CVL_Process");
            });

            modelBuilder.Entity<CvlProcess>(entity =>
            {
                entity.ToTable("CVL_Process");

                entity.Property(e => e.CvlProcessId).HasColumnName("CVL_ProcessID");

                entity.Property(e => e.CvlBasicCourtId).HasColumnName("CVL_BasicCourtID");

                entity.Property(e => e.CvlCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_CreateDate");

                entity.Property(e => e.CvlCreateUserId).HasColumnName("CVL_CreateUserID");

                entity.Property(e => e.CvlDefendantCompanyId).HasColumnName("CVL_DefendantCompanyID");

                entity.Property(e => e.CvlDepartmentId).HasColumnName("CVL_DepartmentID");

                entity.Property(e => e.CvlEventDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_EventDate");

                entity.Property(e => e.CvlExpertIds)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_ExpertIDs");

                entity.Property(e => e.CvlIsDeleted).HasColumnName("CVL_IsDeleted");

                entity.Property(e => e.CvlIsDeletedComment)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_IsDeletedComment");

                entity.Property(e => e.CvlIsDeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_IsDeletedDate");

                entity.Property(e => e.CvlIsDeletedUserId).HasColumnName("CVL_IsDeletedUserID");

                entity.Property(e => e.CvlIsFinished).HasColumnName("CVL_IsFinished");

                entity.Property(e => e.CvlJudgeId).HasColumnName("CVL_JudgeID");

                entity.Property(e => e.CvlLastProcessStatusId).HasColumnName("CVL_LastProcessStatusID");

                entity.Property(e => e.CvlLastStatusComment)
                    .HasMaxLength(2500)
                    .HasColumnName("CVL_LastStatusComment");

                entity.Property(e => e.CvlLastStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_LastStatusDate");

                entity.Property(e => e.CvlLitigationLawyerId).HasColumnName("CVL_litigationLawyerID");

                entity.Property(e => e.CvlProcessCaseNumber)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ProcessCaseNumber");

                entity.Property(e => e.CvlProcessComment)
                    .HasMaxLength(2500)
                    .HasColumnName("CVL_ProcessComment");

                entity.Property(e => e.CvlProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_ProcessDate");

                entity.Property(e => e.CvlProcessPlaintiffName)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_ProcessPlaintiffName");

                entity.Property(e => e.CvlProcessValue)
                    .HasColumnType("money")
                    .HasColumnName("CVL_ProcessValue");

                entity.Property(e => e.CvlReasonId).HasColumnName("CVL_ReasonID");

                entity.Property(e => e.CvlRiskLevelId).HasColumnName("CVL_RiskLevelID");

                entity.Property(e => e.CvlSexpertIds)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_SExpertIDs");

                entity.Property(e => e.CvlSubReasonId).HasColumnName("CVL_SubReasonID");

                entity.HasOne(d => d.CvlBasicCourt)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlBasicCourtId)
                    .HasConstraintName("FK_CVL_Process_CVL_BasicCourt");

                entity.HasOne(d => d.CvlDefendantCompany)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlDefendantCompanyId)
                    .HasConstraintName("FK_CVL_Process_CVL_DefendantCompany");

                entity.HasOne(d => d.CvlDepartment)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlDepartmentId)
                    .HasConstraintName("FK_CVL_Process_CVL_Department");

                entity.HasOne(d => d.CvlJudge)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlJudgeId)
                    .HasConstraintName("FK_CVL_Process_CVL_Judge");

                entity.HasOne(d => d.CvlReason)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlReasonId)
                    .HasConstraintName("FK_CVL_Process_CVL_Reason");

                entity.HasOne(d => d.CvlRiskLevel)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlRiskLevelId)
                    .HasConstraintName("FK_CVL_Process_CVL_RiskLevel");

                entity.HasOne(d => d.CvlSubReason)
                    .WithMany(p => p.CvlProcesses)
                    .HasForeignKey(d => d.CvlSubReasonId)
                    .HasConstraintName("FK_CVL_Process_CVL_SubReason");
            });

            modelBuilder.Entity<CvlProcessDetail>(entity =>
            {
                entity.ToTable("CVL_ProcessDetail");

                entity.Property(e => e.CvlProcessDetailId).HasColumnName("CVL_ProcessDetailID");

                entity.Property(e => e.CvlCaseFinishedAmount)
                    .HasColumnType("money")
                    .HasColumnName("CVL_CaseFinishedAmount");

                entity.Property(e => e.CvlFinishedKedsdebitor).HasColumnName("CVL_FinishedKEDSDebitor");

                entity.Property(e => e.CvlPdCreateComment)
                    .HasMaxLength(2500)
                    .HasColumnName("CVL_PD_CreateComment");

                entity.Property(e => e.CvlPdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_PD_CreateDate");

                entity.Property(e => e.CvlPdCreateUserId).HasColumnName("CVL_PD_CreateUserID");

                entity.Property(e => e.CvlPdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_PD_Date");

                entity.Property(e => e.CvlPdDocumentPath)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_PD_DocumentPath");

                entity.Property(e => e.CvlPdIsDeleted).HasColumnName("CVL_PD_IsDeleted");

                entity.Property(e => e.CvlPdIsDeletedComment)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_PD_IsDeletedComment");

                entity.Property(e => e.CvlPdIsDeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_PD_IsDeletedDate");

                entity.Property(e => e.CvlPdIsDeletedUserId).HasColumnName("CVL_PD_IsDeletedUserID");

                entity.Property(e => e.CvlProcessId).HasColumnName("CVL_ProcessID");

                entity.Property(e => e.CvlProcessStatusId).HasColumnName("CVL_ProcessStatusID");

                entity.HasOne(d => d.CvlProcess)
                    .WithMany(p => p.CvlProcessDetails)
                    .HasForeignKey(d => d.CvlProcessId)
                    .HasConstraintName("FK_CLV_ProcessDetail_CVL_Process");

                entity.HasOne(d => d.CvlProcessStatus)
                    .WithMany(p => p.CvlProcessDetails)
                    .HasForeignKey(d => d.CvlProcessStatusId)
                    .HasConstraintName("FK_CLV_ProcessDetail_CVL_ProcessStatus");
            });

            modelBuilder.Entity<CvlProcessLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVL_ProcessLog");

                entity.Property(e => e.CvlBasicCourtId).HasColumnName("CVL_BasicCourtID");

                entity.Property(e => e.CvlCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_CreateDate");

                entity.Property(e => e.CvlCreateUserId).HasColumnName("CVL_CreateUserID");

                entity.Property(e => e.CvlDefendantCompanyId).HasColumnName("CVL_DefendantCompanyID");

                entity.Property(e => e.CvlDepartmentId).HasColumnName("CVL_DepartmentID");

                entity.Property(e => e.CvlEventDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_EventDate");

                entity.Property(e => e.CvlExpertIds)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_ExpertIDs");

                entity.Property(e => e.CvlIsDeleted).HasColumnName("CVL_IsDeleted");

                entity.Property(e => e.CvlIsDeletedComment)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_IsDeletedComment");

                entity.Property(e => e.CvlIsDeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_IsDeletedDate");

                entity.Property(e => e.CvlIsDeletedUserId).HasColumnName("CVL_IsDeletedUserID");

                entity.Property(e => e.CvlIsFinished).HasColumnName("CVL_IsFinished");

                entity.Property(e => e.CvlJudgeId).HasColumnName("CVL_JudgeID");

                entity.Property(e => e.CvlLastProcessStatusId).HasColumnName("CVL_LastProcessStatusID");

                entity.Property(e => e.CvlLastStatusComment)
                    .HasMaxLength(2500)
                    .HasColumnName("CVL_LastStatusComment");

                entity.Property(e => e.CvlLastStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_LastStatusDate");

                entity.Property(e => e.CvlLitigationLawyerId).HasColumnName("CVL_litigationLawyerID");

                entity.Property(e => e.CvlProcessCaseNumber)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ProcessCaseNumber");

                entity.Property(e => e.CvlProcessComment)
                    .HasMaxLength(2500)
                    .HasColumnName("CVL_ProcessComment");

                entity.Property(e => e.CvlProcessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CVL_ProcessDate");

                entity.Property(e => e.CvlProcessId).HasColumnName("CVL_ProcessID");

                entity.Property(e => e.CvlProcessPlaintiffName)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_ProcessPlaintiffName");

                entity.Property(e => e.CvlProcessValue)
                    .HasColumnType("money")
                    .HasColumnName("CVL_ProcessValue");

                entity.Property(e => e.CvlReasonId).HasColumnName("CVL_ReasonID");

                entity.Property(e => e.CvlRiskLevelId).HasColumnName("CVL_RiskLevelID");

                entity.Property(e => e.CvlSexpertIds)
                    .HasMaxLength(500)
                    .HasColumnName("CVL_SExpertIDs");

                entity.Property(e => e.CvlSubReasonId).HasColumnName("CVL_SubReasonID");
            });

            modelBuilder.Entity<CvlProcessStatus>(entity =>
            {
                entity.ToTable("CVL_ProcessStatus");

                entity.Property(e => e.CvlProcessStatusId).HasColumnName("CVL_ProcessStatusID");

                entity.Property(e => e.CvlProcessStatusIsActive).HasColumnName("CVL_ProcessStatusIsActive");

                entity.Property(e => e.CvlProcessStatusName)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ProcessStatusName");

                entity.Property(e => e.CvlProcessStatusNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ProcessStatusNameAL");
            });

            modelBuilder.Entity<CvlReason>(entity =>
            {
                entity.ToTable("CVL_Reason");

                entity.Property(e => e.CvlReasonId).HasColumnName("CVL_ReasonID");

                entity.Property(e => e.CvlReasonName)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ReasonName");

                entity.Property(e => e.CvlReasonNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_ReasonNameAL");
            });

            modelBuilder.Entity<CvlRiskLevel>(entity =>
            {
                entity.ToTable("CVL_RiskLevel");

                entity.Property(e => e.CvlRiskLevelId).HasColumnName("CVL_RiskLevelID");

                entity.Property(e => e.CvlRiskLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_RiskLevelName");
            });

            modelBuilder.Entity<CvlSexpert>(entity =>
            {
                entity.ToTable("CVL_SExpert");

                entity.Property(e => e.CvlSexpertId).HasColumnName("CVL_SExpertID");

                entity.Property(e => e.CvlSexpertName)
                    .HasMaxLength(50)
                    .HasColumnName("CVL_SExpertName");
            });

            modelBuilder.Entity<CvlSubReason>(entity =>
            {
                entity.ToTable("CVL_SubReason");

                entity.Property(e => e.CvlSubReasonId).HasColumnName("CVL_SubReasonID");

                entity.Property(e => e.CvlSubReasonIsActive).HasColumnName("CVL_SubReasonIsActive");

                entity.Property(e => e.CvlSubReasonName)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_SubReasonName");

                entity.Property(e => e.CvlSubReasonNameAl)
                    .HasMaxLength(250)
                    .HasColumnName("CVL_SubReasonNameAL");
            });

            modelBuilder.Entity<RlAgrNatification>(entity =>
            {
                entity.ToTable("RL_AgrNatification");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

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

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CridentityNr).HasColumnName("CRIdentityNr");

                entity.Property(e => e.CrphoneNr)
                    .HasMaxLength(50)
                    .HasColumnName("CRPhoneNr");

                entity.Property(e => e.CustomerRepresentative).HasMaxLength(250);

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.HasOne(d => d.CaseHistory)
                    .WithMany(p => p.RlAgreements)
                    .HasForeignKey(d => d.CaseHistoryId)
                    .HasConstraintName("FK_RL_Agreement_RL_CaseHistory");
            });

            modelBuilder.Entity<RlAgrinstallment>(entity =>
            {
                entity.HasKey(e => e.AgrInsId);

                entity.ToTable("RL_AGRInstallment");

                entity.Property(e => e.AgrInsId).HasColumnName("AgrInsID");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

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

                entity.Property(e => e.DeletedDate).HasColumnType("date");

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

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AmeterId).HasColumnName("AMeterID");

                entity.Property(e => e.CaseNr).HasMaxLength(50);

                entity.Property(e => e.CreatedComment).HasMaxLength(2500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.DeletedComment).HasMaxLength(2500);

                entity.Property(e => e.DeletedDate).HasColumnType("date");

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.InitiatedDeparment).HasMaxLength(50);

                entity.Property(e => e.LastStatusDate).HasColumnType("date");

                entity.Property(e => e.LastStatusId).HasColumnName("LastStatusID");

                entity.Property(e => e.MainResponsibleUserId).HasColumnName("MainResponsibleUserID");

                entity.Property(e => e.PhoneNr).HasMaxLength(50);

                entity.Property(e => e.SecondResponsibleUserId).HasColumnName("SecondResponsibleUserID");

                entity.Property(e => e.SourceApp).HasMaxLength(50);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Subdistrict).HasMaxLength(250);
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

            modelBuilder.Entity<RlCaseNatification>(entity =>
            {
                entity.HasKey(e => e.Cnid);

                entity.ToTable("RL_CaseNatifications");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CaseHistoryId).HasColumnName("CaseHistoryID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

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

            modelBuilder.Entity<RlCninvoice>(entity =>
            {
                entity.ToTable("RL_CNInvoices");

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.DeletedDate).HasColumnType("date");

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

                entity.Property(e => e.AgencyId)
                    .HasMaxLength(3)
                    .HasColumnName("AgencyID");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CreatedComment).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.CreditInv).HasColumnType("money");

                entity.Property(e => e.DeletedComment).HasMaxLength(500);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.EldebitorId).HasColumnName("EldebitorID");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceAmountInv).HasColumnType("money");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceIdccp).HasColumnName("InvoiceIDCCP");

                entity.Property(e => e.InvoiceIdrl).HasColumnName("InvoiceIDRL");

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

                entity.Property(e => e.BlockedDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
