using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseHistoryDTO;
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
    public class CaseHistoryRepository : ICaseHistoryRepository
    {
        private readonly BaseRepository baseRepo;
        public CaseHistoryRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<CaseHistoryResponseDTO> CUDRLCaseHistory(CUDCaseHistoryDTO objDTO)
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

                        await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new CaseHistoryResponseDTO()
                        {
                            CreatedUser = objDTO.UserId,
                            CaseHistoryId = objDTO.CaseHistoryID,
                            CaseId = objDTO.CaseId,
                            StatusId = objDTO.StatusId,
                            StatusDate = DateTime.Parse(objDTO.StatusDate),
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

        public async Task<IEnumerable<CaseHistoryResponseDTO>> GetRLCaseHistory(CaseHistoryDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.RL_get_CaseHistory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var items = new List<CaseHistoryResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new CaseHistoryResponseDTO();
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.CaseHistoryId = int.Parse(reader["CaseHistoryID"].ToString());
                            item.StatusId = int.Parse(reader["StatusID"].ToString());
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
    }
}
