using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository
{
    public class ReclaimLossesRepository : IReclaimLossesRepository
    {
        private readonly BaseRepository baseRepo;
        public ReclaimLossesRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }

        public async Task<ReclaimLossesCaseDTO> CreateRLCase(ReclaimLossesCaseDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
                        cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
                        cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
                        cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
                        cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
                        cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
                        cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
                        cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
                        cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
                        cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

                        var r=await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseDTO()
                        {
                            CaseId = objDTO.CaseId,
                            UserId = objDTO.UserId,
                            CaseNr = objDTO.CaseNr,
                            AgencyId = objDTO.AgencyId,
                            EldebitorId = objDTO.EldebitorId,
                            AMeterId = objDTO.AMeterId,
                            Subdistrict=objDTO.Subdistrict,
                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr, 
                            PhoneNr = objDTO.PhoneNr,
                            Address = objDTO.Address,
                            TariffId = objDTO.TariffId,
                            Municipality=  objDTO.Municipality,
                            BirthDate = objDTO.BirthDate,
                            DepartmentId = objDTO.DepartmentId,
                            StatusId= objDTO.StatusId,
                            CreatedDate = objDTO.CreatedDate,
                            MainResponsibleUserId= objDTO.MainResponsibleUserId,
                            SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
                            SourceApp=objDTO.SourceApp,
                            SourceId=objDTO.SourceId,
                            CreatedComment=objDTO.CreatedComment
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<ReclaimLossesCaseDTO> DeleteRLCase(ReclaimLossesCaseDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
                        cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
                        cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
                        cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
                        cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
                        cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
                        cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
                        cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
                        cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
                        cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseDTO()
                        {
                            CaseId = objDTO.CaseId,
                            UserId = objDTO.UserId,
                            CaseNr = objDTO.CaseNr,
                            AgencyId = objDTO.AgencyId,
                            EldebitorId = objDTO.EldebitorId,
                            AMeterId = objDTO.AMeterId,
                            Subdistrict = objDTO.Subdistrict,
                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr,
                            PhoneNr = objDTO.PhoneNr,
                            Address = objDTO.Address,
                            TariffId = objDTO.TariffId,
                            Municipality = objDTO.Municipality,
                            BirthDate = objDTO.BirthDate,
                            DepartmentId = objDTO.DepartmentId,
                            StatusId = objDTO.StatusId,
                            CreatedDate = objDTO.CreatedDate,
                            MainResponsibleUserId = objDTO.MainResponsibleUserId,
                            SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
                            SourceApp = objDTO.SourceApp,
                            SourceId = objDTO.SourceId,
                            CreatedComment = objDTO.CreatedComment
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<ReclaimLossesCaseDTO> GetRLCase(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLCases(int? id = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ReclaimLossesCaseDTO> UpdateRLCase(ReclaimLossesCaseDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
                        cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
                        cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
                        cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
                        cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
                        cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
                        cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
                        cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
                        cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
                        cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseDTO()
                        {
                            CaseId = objDTO.CaseId,
                            UserId = objDTO.UserId,
                            CaseNr = objDTO.CaseNr,
                            AgencyId = objDTO.AgencyId,
                            EldebitorId = objDTO.EldebitorId,
                            AMeterId = objDTO.AMeterId,
                            Subdistrict = objDTO.Subdistrict,
                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr,
                            PhoneNr = objDTO.PhoneNr,
                            Address = objDTO.Address,
                            TariffId = objDTO.TariffId,
                            Municipality = objDTO.Municipality,
                            BirthDate = objDTO.BirthDate,
                            DepartmentId = objDTO.DepartmentId,
                            StatusId = objDTO.StatusId,
                            CreatedDate = objDTO.CreatedDate,
                            MainResponsibleUserId = objDTO.MainResponsibleUserId,
                            SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
                            SourceApp = objDTO.SourceApp,
                            SourceId = objDTO.SourceId,
                            CreatedComment = objDTO.CreatedComment
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
