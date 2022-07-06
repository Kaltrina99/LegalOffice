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

        #region RLCase
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
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
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
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
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
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
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
        #endregion

        #region RLCaseHistory
        public async Task<ReclaimLossesCaseHistoryDTO> CreateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseHistoryDTO()
                        {
                            UserId = objDTO.UserId,
                            CaseHistoryID = objDTO.CaseHistoryID,
                            CaseId = objDTO.CaseId,
                            StatusId = objDTO.StatusId,
                            StatusDate = objDTO.StatusDate,
                            CreatedComment = objDTO.CreatedComment,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<ReclaimLossesCaseHistoryDTO> UpdateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseHistoryDTO()
                        {
                            UserId = objDTO.UserId,
                            CaseHistoryID = objDTO.CaseHistoryID,
                            CaseId = objDTO.CaseId,
                            StatusId = objDTO.StatusId,
                            StatusDate = objDTO.StatusDate,
                            CreatedComment = objDTO.CreatedComment,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<ReclaimLossesCaseHistoryDTO> DeleteRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseHistoryDTO()
                        {
                            UserId = objDTO.UserId,
                            CaseHistoryID = objDTO.CaseHistoryID,
                            CaseId = objDTO.CaseId,
                            StatusId = objDTO.StatusId,
                            StatusDate = objDTO.StatusDate,
                            CreatedComment = objDTO.CreatedComment,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<ReclaimLossesCaseHistoryDTO> GetRLCaseHistory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseHistoryDTO>> GetAllRLCaseHistories(int? id = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLCaseNotification
        public Task<ReclaimLossesCaseDTO> CreateRLCaseNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> UpdateRLCaseNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> DeleteRLCaseNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> GetRLCaseNotification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLCaseNotifications(int? id = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLAgreement
        public Task<ReclaimLossesCaseDTO> CreateRLAgreement(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> UpdateRLAgreement(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> DeleteRLAgreement(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> GetRLAgreement(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLAgreements(int? id = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLAgreementNotificatin
        public Task<ReclaimLossesCaseDTO> CreateRLAgreementNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> UpdateRLAgreementNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> DeleteRLAgreementNotification(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> GetRLAgreementNotification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLAgreementNotifications(int? id = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLManualPayment
        public Task<ReclaimLossesCaseDTO> CreateRLManualPayment(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> UpdateRLManualPayment(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> DeleteRLManualPayment(ReclaimLossesCaseDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLManualPayment(int? id = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
