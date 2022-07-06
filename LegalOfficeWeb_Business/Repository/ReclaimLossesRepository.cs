﻿using LegalOfficeWeb_Business.Repository.IRepository;
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
        public async Task<ReclaimLossesCaseDTO> CUDRLCase(ReclaimLossesCaseDTO objDTO)
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
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

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
                            CreatedComment = objDTO.CreatedComment,
                            ProcessType= objDTO.ProcessType,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public async Task<ReclaimLossesCaseDTO> CreateRLCase(ReclaimLossesCaseDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
                        
        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
        //                cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
        //                cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
        //                cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
        //                cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
        //                cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
        //                cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
        //                cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
        //                cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
        //                cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
        //                cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
        //                cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r=await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseNr = objDTO.CaseNr,
        //                    AgencyId = objDTO.AgencyId,
        //                    EldebitorId = objDTO.EldebitorId,
        //                    AMeterId = objDTO.AMeterId,
        //                    Subdistrict=objDTO.Subdistrict,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr, 
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Address = objDTO.Address,
        //                    TariffId = objDTO.TariffId,
        //                    Municipality=  objDTO.Municipality,
        //                    BirthDate = objDTO.BirthDate,
        //                    DepartmentId = objDTO.DepartmentId,
        //                    StatusId= objDTO.StatusId,
        //                    CreatedDate = objDTO.CreatedDate,
        //                    MainResponsibleUserId= objDTO.MainResponsibleUserId,
        //                    SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
        //                    SourceApp=objDTO.SourceApp,
        //                    SourceId=objDTO.SourceId,
        //                    CreatedComment=objDTO.CreatedComment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseDTO> UpdateRLCase(ReclaimLossesCaseDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
        //                cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
        //                cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
        //                cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
        //                cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
        //                cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
        //                cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
        //                cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
        //                cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
        //                cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
        //                cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
        //                cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseNr = objDTO.CaseNr,
        //                    AgencyId = objDTO.AgencyId,
        //                    EldebitorId = objDTO.EldebitorId,
        //                    AMeterId = objDTO.AMeterId,
        //                    Subdistrict = objDTO.Subdistrict,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Address = objDTO.Address,
        //                    TariffId = objDTO.TariffId,
        //                    Municipality = objDTO.Municipality,
        //                    BirthDate = objDTO.BirthDate,
        //                    DepartmentId = objDTO.DepartmentId,
        //                    StatusId = objDTO.StatusId,
        //                    CreatedDate = objDTO.CreatedDate,
        //                    MainResponsibleUserId = objDTO.MainResponsibleUserId,
        //                    SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
        //                    SourceApp = objDTO.SourceApp,
        //                    SourceId = objDTO.SourceId,
        //                    CreatedComment = objDTO.CreatedComment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseDTO> DeleteRLCase(ReclaimLossesCaseDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCase", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseNr);
        //                cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
        //                cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
        //                cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
        //                cmd.Parameters.AddWithValue("@prp_Subdistrict", objDTO.Subdistrict);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Address", objDTO.Address);
        //                cmd.Parameters.AddWithValue("@prp_TariffID", objDTO.TariffId);
        //                cmd.Parameters.AddWithValue("@prp_Municipality", objDTO.Municipality);
        //                cmd.Parameters.AddWithValue("@prp_BirthDate", objDTO.BirthDate);
        //                cmd.Parameters.AddWithValue("@prp_DepartmentID", objDTO.DepartmentId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.CreatedDate);
        //                cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
        //                cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
        //                cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
        //                cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseNr = objDTO.CaseNr,
        //                    AgencyId = objDTO.AgencyId,
        //                    EldebitorId = objDTO.EldebitorId,
        //                    AMeterId = objDTO.AMeterId,
        //                    Subdistrict = objDTO.Subdistrict,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Address = objDTO.Address,
        //                    TariffId = objDTO.TariffId,
        //                    Municipality = objDTO.Municipality,
        //                    BirthDate = objDTO.BirthDate,
        //                    DepartmentId = objDTO.DepartmentId,
        //                    StatusId = objDTO.StatusId,
        //                    CreatedDate = objDTO.CreatedDate,
        //                    MainResponsibleUserId = objDTO.MainResponsibleUserId,
        //                    SecondResponsibleUserId = objDTO.SecondResponsibleUserId,
        //                    SourceApp = objDTO.SourceApp,
        //                    SourceId = objDTO.SourceId,
        //                    CreatedComment = objDTO.CreatedComment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesCaseDTO> GetRLCase(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReclaimLossesCaseResponseDTO>> GetAllRLCases()
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_Case_GetALL", con))
                    {
                      
                        var reader = cmd.ExecuteReader();


                        var items = new List<ReclaimLossesCaseResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new ReclaimLossesCaseResponseDTO();
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseNr = reader["CaseNr"].ToString();
                            item.AgencyId = reader["AgencyId"].ToString();
                            item.EldebitorId = int.Parse(reader["EldebitorId"].ToString());
                            item.CustomerName = reader["CustomerName"].ToString();
                            item.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                            item.MainResponsibleUserId = int.Parse(reader["MainResponsibleUserId"].ToString());
                            item.SecondResponsibleUserId = int.Parse(reader["SecondResponsibleUserId"].ToString());
                            item.SourceApp = reader["SourceApp"].ToString();
                            item.SourceId = int.Parse(reader["SourceId"].ToString());
                            item.SourceDate = reader["SourceDate"].ToString();
                            item.Subdistrict = reader["Subdistrict"].ToString();
                            item.AMeterId = int.Parse(reader["AMeterId"].ToString());
                            item.TariffId = reader["TariffId"].ToString();
                            item.IdentityNr = reader["IdentityNr"].ToString();
                            item.PhoneNr = reader["PhoneNr"].ToString();
                            item.Address = reader["Address"].ToString();
                            item.Municipality = reader["Municipality"].ToString();
                            item.BirthDate = reader["BirthDate"].ToString();
                            item.CreatedDate = reader["CreatedDate"].ToString();
                            item.CreatedUser = reader["CreatedUser"].ToString();
                            item.CreatedComment = reader["CreatedComment"].ToString();
                            item.Active = bool.Parse(reader["Active"].ToString());
                            items.Add(item);
                        }
                        con.Close();
                        return items;
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
        public async Task<ReclaimLossesCaseHistoryDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
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
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

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

        //public async Task<ReclaimLossesCaseHistoryDTO> CreateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseHistoryDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CaseId = objDTO.CaseId,
        //                    StatusId = objDTO.StatusId,
        //                    StatusDate = objDTO.StatusDate,
        //                    CreatedComment = objDTO.CreatedComment,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseHistoryDTO> UpdateRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseHistoryDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CaseId = objDTO.CaseId,
        //                    StatusId = objDTO.StatusId,
        //                    StatusDate = objDTO.StatusDate,
        //                    CreatedComment = objDTO.CreatedComment,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseHistoryDTO> DeleteRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDCaseHistory", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
        //                cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseHistoryDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CaseId = objDTO.CaseId,
        //                    StatusId = objDTO.StatusId,
        //                    StatusDate = objDTO.StatusDate,
        //                    CreatedComment = objDTO.CreatedComment,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesCaseHistoryDTO> GetRLCaseHistory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseHistoryDTO>> GetAllRLCaseHistories()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLCaseNotification
        public async Task<ReclaimLossesCaseNotificationDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("RL_trn_IUDCaseNatification", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseHistoryID);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_WaitingDays", objDTO.WaitingDay);
                        cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesCaseNotificationDTO()
                        {
                            CaseId = objDTO.CaseId,
                            UserId = objDTO.UserId,
                            CaseHistoryID = objDTO.CaseHistoryID,
                            CreatedComment = objDTO.CreatedComment,
                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr,
                            PhoneNr = objDTO.PhoneNr,
                            WaitingDay = objDTO.WaitingDay,
                            InvoiceIDs = objDTO.InvoiceIDs,
                            ProcessType = objDTO.ProcessType,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public async Task<ReclaimLossesCaseNotificationDTO> CreateRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("RL_trn_IUDCaseNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_WaitingDays", objDTO.WaitingDay);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseNotificationDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CreatedComment = objDTO.CreatedComment,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    WaitingDay = objDTO.WaitingDay,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseNotificationDTO> UpdateRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("RL_trn_IUDCaseNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_WaitingDays", objDTO.WaitingDay);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseNotificationDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CreatedComment = objDTO.CreatedComment,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    WaitingDay = objDTO.WaitingDay,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesCaseNotificationDTO> DeleteRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("RL_trn_IUDCaseNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseNr", objDTO.CaseHistoryID);
        //                cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_WaitingDays", objDTO.WaitingDay);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesCaseNotificationDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    CaseHistoryID = objDTO.CaseHistoryID,
        //                    CreatedComment = objDTO.CreatedComment,
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    WaitingDay = objDTO.WaitingDay,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesCaseNotificationDTO> GetRLCaseNotification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseNotificationDTO>> GetAllRLCaseNotifications()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLAgreement
        public async Task<ReclaimLossesAgreementDTO> CUDRLAgreement(ReclaimLossesAgreementDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgreement", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryId);
                        cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
                        cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_CustomerRepresentative", objDTO.CustomerRepresentative);
                        cmd.Parameters.AddWithValue("@prp_CRPhoneNr", objDTO.CRPhoneNr);
                        cmd.Parameters.AddWithValue("@prp_CRIdentityNr", objDTO.CRIdentityNr);
                        cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
                        cmd.Parameters.AddWithValue("@prp_InsIDs", objDTO.InsIDs);
                        cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesAgreementDTO()
                        {
                            CaseId = objDTO.CaseId,
                            UserId = objDTO.UserId,
                            AgreementId = objDTO.AgreementId,
                            CaseHistoryId = objDTO.CaseHistoryId,

                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr,
                            PhoneNr = objDTO.PhoneNr,
                            CustomerRepresentative = objDTO.CustomerRepresentative,
                            CRPhoneNr = objDTO.CRPhoneNr,
                            CRIdentityNr = objDTO.CRIdentityNr,
                            InvoiceIDs = objDTO.InvoiceIDs,
                            InsIDs = objDTO.InsIDs,
                            Comment = objDTO.Comment,
                            ProcessType = objDTO.ProcessType,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public async Task<ReclaimLossesAgreementDTO> CreateRLAgreement(ReclaimLossesAgreementDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgreement", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryId);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CustomerRepresentative", objDTO.CustomerRepresentative);
        //                cmd.Parameters.AddWithValue("@prp_CRPhoneNr", objDTO.CRPhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CRIdentityNr", objDTO.CRIdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_InsIDs", objDTO.InsIDs);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    AgreementId = objDTO.AgreementId,
        //                    CaseHistoryId = objDTO.CaseHistoryId,
                            
        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    CustomerRepresentative = objDTO.CustomerRepresentative,
        //                    CRPhoneNr = objDTO.CRPhoneNr,
        //                    CRIdentityNr = objDTO.CRIdentityNr,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                    InsIDs = objDTO.InsIDs,
        //                    Comment = objDTO.Comment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesAgreementDTO> UpdateRLAgreement(ReclaimLossesAgreementDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgreement", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryId);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CustomerRepresentative", objDTO.CustomerRepresentative);
        //                cmd.Parameters.AddWithValue("@prp_CRPhoneNr", objDTO.CRPhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CRIdentityNr", objDTO.CRIdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_InsIDs", objDTO.InsIDs);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    AgreementId = objDTO.AgreementId,
        //                    CaseHistoryId = objDTO.CaseHistoryId,

        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    CustomerRepresentative = objDTO.CustomerRepresentative,
        //                    CRPhoneNr = objDTO.CRPhoneNr,
        //                    CRIdentityNr = objDTO.CRIdentityNr,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                    InsIDs = objDTO.InsIDs,
        //                    Comment = objDTO.Comment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesAgreementDTO> DeleteRLAgreement(ReclaimLossesAgreementDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgreement", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
        //                cmd.Parameters.AddWithValue("@prp_CaseHistoryID", objDTO.CaseHistoryId);
        //                cmd.Parameters.AddWithValue("@prp_CustomerName", objDTO.CustomerName);
        //                cmd.Parameters.AddWithValue("@prp_IdentityNr", objDTO.IdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CustomerRepresentative", objDTO.CustomerRepresentative);
        //                cmd.Parameters.AddWithValue("@prp_CRPhoneNr", objDTO.CRPhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_CRIdentityNr", objDTO.CRIdentityNr);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceIDs", objDTO.InvoiceIDs);
        //                cmd.Parameters.AddWithValue("@prp_InsIDs", objDTO.InsIDs);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementDTO()
        //                {
        //                    CaseId = objDTO.CaseId,
        //                    UserId = objDTO.UserId,
        //                    AgreementId = objDTO.AgreementId,
        //                    CaseHistoryId = objDTO.CaseHistoryId,

        //                    CustomerName = objDTO.CustomerName,
        //                    IdentityNr = objDTO.IdentityNr,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    CustomerRepresentative = objDTO.CustomerRepresentative,
        //                    CRPhoneNr = objDTO.CRPhoneNr,
        //                    CRIdentityNr = objDTO.CRIdentityNr,
        //                    InvoiceIDs = objDTO.InvoiceIDs,
        //                    InsIDs = objDTO.InsIDs,
        //                    Comment = objDTO.Comment
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesAgreementDTO> GetRLAgreement(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesAgreementDTO>> GetAllRLAgreements()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLAgreementNotificatin
        public async Task<ReclaimLossesAgreementNotificationDTO> CUDRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgNatification", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_NatificationID", objDTO.NotificationID);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementID);
                        cmd.Parameters.AddWithValue("@prp_NatificationText", objDTO.NotificationText);
                        cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
                        cmd.Parameters.AddWithValue("@prp_Email", objDTO.Email);
                        cmd.Parameters.AddWithValue("@prp_ForCustomer", objDTO.ForCustomer);
                        cmd.Parameters.AddWithValue("@prp_IsSent", objDTO.IsSent);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesAgreementNotificationDTO()
                        {

                            UserId = objDTO.UserId,
                            NotificationID = objDTO.NotificationID,
                            AgreementID = objDTO.AgreementID,
                            NotificationText = objDTO.NotificationText,
                            PhoneNr = objDTO.PhoneNr,
                            Email = objDTO.Email,
                            ForCustomer = objDTO.ForCustomer,
                            IsSent = objDTO.IsSent,
                            ProcessType = objDTO.ProcessType,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public async Task<ReclaimLossesAgreementNotificationDTO> CreateRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_NatificationID", objDTO.NotificationID);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementID);
        //                cmd.Parameters.AddWithValue("@prp_NatificationText", objDTO.NotificationText);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Email", objDTO.Email);
        //                cmd.Parameters.AddWithValue("@prp_ForCustomer", objDTO.ForCustomer);
        //                cmd.Parameters.AddWithValue("@prp_IsSent", objDTO.IsSent);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementNotificationDTO()
        //                {
                            
        //                    UserId = objDTO.UserId,
        //                    NotificationID = objDTO.NotificationID,
        //                    AgreementID = objDTO.AgreementID,
        //                    NotificationText = objDTO.NotificationText,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Email = objDTO.Email,
        //                    ForCustomer = objDTO.ForCustomer,
        //                    IsSent = objDTO.IsSent,
                           
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesAgreementNotificationDTO> UpdateRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_NatificationID", objDTO.NotificationID);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementID);
        //                cmd.Parameters.AddWithValue("@prp_NatificationText", objDTO.NotificationText);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Email", objDTO.Email);
        //                cmd.Parameters.AddWithValue("@prp_ForCustomer", objDTO.ForCustomer);
        //                cmd.Parameters.AddWithValue("@prp_IsSent", objDTO.IsSent);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementNotificationDTO()
        //                {

        //                    UserId = objDTO.UserId,
        //                    NotificationID = objDTO.NotificationID,
        //                    AgreementID = objDTO.AgreementID,
        //                    NotificationText = objDTO.NotificationText,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Email = objDTO.Email,
        //                    ForCustomer = objDTO.ForCustomer,
        //                    IsSent = objDTO.IsSent,

        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesAgreementNotificationDTO> DeleteRLAgreementNotification(ReclaimLossesAgreementNotificationDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDAgNatification", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_NatificationID", objDTO.NotificationID);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementID);
        //                cmd.Parameters.AddWithValue("@prp_NatificationText", objDTO.NotificationText);
        //                cmd.Parameters.AddWithValue("@prp_PhoneNr", objDTO.PhoneNr);
        //                cmd.Parameters.AddWithValue("@prp_Email", objDTO.Email);
        //                cmd.Parameters.AddWithValue("@prp_ForCustomer", objDTO.ForCustomer);
        //                cmd.Parameters.AddWithValue("@prp_IsSent", objDTO.IsSent);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesAgreementNotificationDTO()
        //                {

        //                    UserId = objDTO.UserId,
        //                    NotificationID = objDTO.NotificationID,
        //                    AgreementID = objDTO.AgreementID,
        //                    NotificationText = objDTO.NotificationText,
        //                    PhoneNr = objDTO.PhoneNr,
        //                    Email = objDTO.Email,
        //                    ForCustomer = objDTO.ForCustomer,
        //                    IsSent = objDTO.IsSent,

        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesAgreementNotificationDTO> GetRLAgreementNotification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesAgreementNotificationDTO>> GetAllRLAgreementNotifications()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RLManualPayment
        public async Task<ReclaimLossesManualPaymentDTO> CUDRLManualPayment(ReclaimLossesManualPaymentDTO objDTO)
        {

            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_trn_IUDManualPayment", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_PaymentID", objDTO.PaymentId);
                        cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
                        cmd.Parameters.AddWithValue("@prp_InvoiceID", objDTO.InvoiceId);
                        cmd.Parameters.AddWithValue("@prp_CollectionID", objDTO.CollectionId);
                        cmd.Parameters.AddWithValue("@prp_Credit", objDTO.Credit);
                        cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
                        cmd.Parameters.AddWithValue("@prp_DocName", objDTO.DocName);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.DocName);

                        var r = await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new ReclaimLossesManualPaymentDTO()
                        {
                            UserId = objDTO.UserId,
                            PaymentId = objDTO.PaymentId,
                            AgreementId = objDTO.AgreementId,
                            InvoiceId = objDTO.InvoiceId,
                            CollectionId = objDTO.CollectionId,
                            Credit = objDTO.Credit,
                            Comment = objDTO.Comment,
                            DocName = objDTO.DocName,
                            ProcessType = objDTO.ProcessType,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public async Task<ReclaimLossesManualPaymentDTO> CreateRLManualPayment(ReclaimLossesManualPaymentDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDManualPayment", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_PaymentID", objDTO.PaymentId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceID", objDTO.InvoiceId);
        //                cmd.Parameters.AddWithValue("@prp_CollectionID", objDTO.CollectionId);
        //                cmd.Parameters.AddWithValue("@prp_Credit", objDTO.Credit);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_DocName", objDTO.DocName);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 1);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesManualPaymentDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    PaymentId = objDTO.PaymentId,
        //                    AgreementId = objDTO.AgreementId,
        //                    InvoiceId = objDTO.InvoiceId,
        //                    CollectionId = objDTO.CollectionId,
        //                    Credit = objDTO.Credit,
        //                    Comment = objDTO.Comment,
        //                    DocName = objDTO.DocName,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesManualPaymentDTO> UpdateRLManualPayment(ReclaimLossesManualPaymentDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDManualPayment", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_PaymentID", objDTO.PaymentId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceID", objDTO.InvoiceId);
        //                cmd.Parameters.AddWithValue("@prp_CollectionID", objDTO.CollectionId);
        //                cmd.Parameters.AddWithValue("@prp_Credit", objDTO.Credit);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_DocName", objDTO.DocName);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 2);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesManualPaymentDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    PaymentId = objDTO.PaymentId,
        //                    AgreementId = objDTO.AgreementId,
        //                    InvoiceId = objDTO.InvoiceId,
        //                    CollectionId = objDTO.CollectionId,
        //                    Credit = objDTO.Credit,
        //                    Comment = objDTO.Comment,
        //                    DocName = objDTO.DocName,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public async Task<ReclaimLossesManualPaymentDTO> DeleteRLManualPayment(ReclaimLossesManualPaymentDTO objDTO)
        //{
        //    try
        //    {
        //        using (var con = baseRepo.GetConnection())
        //        {
        //            using (var cmd = new SqlCommand("dbo.RL_trn_IUDManualPayment", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
        //                cmd.Parameters.AddWithValue("@prp_PaymentID", objDTO.PaymentId);
        //                cmd.Parameters.AddWithValue("@prp_AgreementID", objDTO.AgreementId);
        //                cmd.Parameters.AddWithValue("@prp_InvoiceID", objDTO.InvoiceId);
        //                cmd.Parameters.AddWithValue("@prp_CollectionID", objDTO.CollectionId);
        //                cmd.Parameters.AddWithValue("@prp_Credit", objDTO.Credit);
        //                cmd.Parameters.AddWithValue("@prp_Comment", objDTO.Comment);
        //                cmd.Parameters.AddWithValue("@prp_DocName", objDTO.DocName);
        //                cmd.Parameters.AddWithValue("@prp_ProcessType", 3);

        //                var r = await cmd.ExecuteNonQueryAsync();
        //                con.Close();
        //                return new ReclaimLossesManualPaymentDTO()
        //                {
        //                    UserId = objDTO.UserId,
        //                    PaymentId = objDTO.PaymentId,
        //                    AgreementId = objDTO.AgreementId,
        //                    InvoiceId = objDTO.InvoiceId,
        //                    CollectionId = objDTO.CollectionId,
        //                    Credit = objDTO.Credit,
        //                    Comment = objDTO.Comment,
        //                    DocName = objDTO.DocName,
        //                };

        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public Task<ReclaimLossesCaseDTO> GetRLManualPayment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReclaimLossesCaseDTO>> GetAllRLManualPayment()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
