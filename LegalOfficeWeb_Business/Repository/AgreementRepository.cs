using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.AgreementDTO;
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
    public class AgreementRepository: IAgreementRepository
    {
        private readonly BaseRepository baseRepo;
        public AgreementRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<AgreementResponseDTO> CUDRLAgreement(CUDAgreementDTO objDTO)
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
                        return new AgreementResponseDTO()
                        {
                            CaseId = objDTO.CaseId,
                            CaseHistoryId = objDTO.CaseHistoryId,
                            CustomerName = objDTO.CustomerName,
                            IdentityNr = objDTO.IdentityNr,
                            PhoneNr = objDTO.PhoneNr,
                            CustomerRepresentative = objDTO.CustomerRepresentative
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<AgreementResponseDTO> GetRLAgreement(AgreementDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_Agreement", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_AgreementId", objDTO.AgreementId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new AgreementResponseDTO();
                        while (await reader.ReadAsync())
                        {
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.AgencyId = reader["AgencyId"].ToString();
                            item.EldebitorId = int.Parse(reader["EldebitorId"].ToString());
                            item.CustomerName = reader["CustomerName"].ToString();
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
        public async Task<IEnumerable<AgreementResponseDTO>> GetAllRLAgreements(AgreementDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_rpr_Agreements", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_District", objDTO.District);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<AgreementResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new AgreementResponseDTO();
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.AgencyId = reader["AgencyId"].ToString();
                            item.EldebitorId = int.Parse(reader["EldebitorId"].ToString());
                            item.CustomerName = reader["CustomerName"].ToString();
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
    }
}
