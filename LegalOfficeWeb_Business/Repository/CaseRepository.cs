using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
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
    public class CaseRepository : ICaseRepository
    {
        private readonly BaseRepository baseRepo;
        public CaseRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<CasesResponseDTO> CUDRLCase(CUDCaseDTO objDTO)
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
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
                        cmd.Parameters.AddWithValue("@prp_MainResponsibleUserID", objDTO.MainResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SecondResponsibleUserID", objDTO.SecondResponsibleUserId);
                        cmd.Parameters.AddWithValue("@prp_SourceApp", objDTO.SourceApp);
                        cmd.Parameters.AddWithValue("@prp_SourceID", objDTO.SourceId);
                        cmd.Parameters.AddWithValue("@prp_SourceDate", objDTO.SourceDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);
                        
                        await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new CasesResponseDTO()
                        {
                           //
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<CasesResponseDTO>> GetAllRLCases(CaseDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_rpr_Cases", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_District", objDTO.District);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<CasesResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new CasesResponseDTO();
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseNr = reader["CaseNr"].ToString();
                            item.AgencyId = reader["AgencyId"].ToString();
                            item.EldebitorId = reader["EldebitorId"].ToString();
                            item.CustomerName = reader["CustomerName"].ToString();
                            item.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                            item.DepartmentName = reader["DepartmentName"].ToString();
                            item.DepartmentNameAL = reader["DepartmentNameAL"].ToString();
                            item.MainResponsibleUserId = int.Parse(reader["MainResponsibleUserId"].ToString());
                            item.MainResponsibleUser = reader["MainResponsibleUser"].ToString();
                            item.SecondResponsibleUserId = int.Parse(reader["SecondResponsibleUserId"].ToString());
                            item.SecondResponsibleUser = reader["SecondResponsibleUser"].ToString();
                            item.SourceApp = reader["SourceApp"].ToString();
                            item.SourceId = int.Parse(reader["SourceId"].ToString());
                            item.SourceDate = DateTime.Parse(reader["SourceDate"].ToString());
                            item.CreatedComment = reader["CreatedComment"].ToString();
                            item.StatusName = reader["StatusName"].ToString();
                            item.StatusNameAL = reader["StatusNameAL"].ToString();
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

        public async Task<CasesResponseDTO> GetRLCase(CaseDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_Case", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_District", objDTO.District);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new CasesResponseDTO();
                        while (await reader.ReadAsync())
                        {
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseNr = reader["CaseNr"].ToString();
                            item.AgencyId = reader["AgencyId"].ToString();
                            item.EldebitorId = reader["EldebitorId"].ToString();
                            item.CustomerName = reader["CustomerName"].ToString();
                            item.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                            item.DepartmentName = reader["DepartmentName"].ToString();
                            item.DepartmentNameAL = reader["DepartmentNameAL"].ToString();
                            item.MainResponsibleUserId = int.Parse(reader["MainResponsibleUserId"].ToString());
                            item.MainResponsibleUser = reader["MainResponsibleUser"].ToString();
                            item.SecondResponsibleUserId = int.Parse(reader["SecondResponsibleUserId"].ToString());
                            item.SecondResponsibleUser = reader["SecondResponsibleUser"].ToString();
                            item.SourceApp = reader["SourceApp"].ToString();
                            item.SourceId = int.Parse(reader["SourceId"].ToString());
                            item.SourceDate = DateTime.Parse(reader["SourceDate"].ToString());
                            item.CreatedComment = reader["CreatedComment"].ToString();
                            item.StatusName = reader["StatusName"].ToString();
                            item.StatusNameAL = reader["StatusNameAL"].ToString();
                        }
                        con.Close();
                        return item;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<CaseInputResponseDTO> GetRLCaseInputs(CaseInputDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_CaseInputs", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new CaseInputResponseDTO();
                        while (await reader.ReadAsync())
                        {
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseInputId = int.Parse(reader["CaseIputId"].ToString());
                            item.AMeterID = int.Parse(reader["AMeterID"].ToString());
                            item.Subdistrict = reader["Subdistrict"].ToString();
                            item.IdentityNr = reader["IdentityNr"].ToString();
                            item.PhoneNr = reader["PhoneNr"].ToString();
                            item.Address = reader["Address"].ToString();
                            item.TariffId = reader["TariffID"].ToString();
                            item.Municipality = reader["Municipality"].ToString();
                            item.BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());

                        }
                        con.Close();
                        return item;
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
