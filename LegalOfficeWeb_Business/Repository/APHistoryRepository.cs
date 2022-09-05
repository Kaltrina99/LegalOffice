using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.HistoryDTO;
using LegalOfficeWeb_Models.MainDTO;
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
    public class APHistoryRepository : IAPHistoryRepository
    {
        private readonly BaseRepository baseRepo;
        public APHistoryRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<HistoryResponseDTO> CUDAPHistory(CUDHistoryDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_trn_IUDHistory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_APMainID", objDTO.APManinId);
                        cmd.Parameters.AddWithValue("@prp_APHistoryID", objDTO.APHistoryId);
                        cmd.Parameters.AddWithValue("@prp_StatusID", objDTO.StatusId);
                        cmd.Parameters.AddWithValue("@prp_StatusDate", objDTO.StatusDate);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new HistoryResponseDTO()
                        {
                            CreatedUser = objDTO.UserId,
                            APHistoryId = objDTO.APHistoryId,
                            APManinId = objDTO.APManinId,
                            StatusId = objDTO.StatusId,
                            StatusDate = objDTO.StatusDate,
                            StatusComment = objDTO.CreatedComment,
                        };

                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<HistoryResponseDTO>> GetAPHistory(HistoryDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_get_History", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_APMainID", objDTO.APMainId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var items = new List<HistoryResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new HistoryResponseDTO();
                            item.APManinId = int.Parse(reader["APMsinID"].ToString());
                            item.APHistoryId = int.Parse(reader["APHistoryID"].ToString());
                            item.StatusId = int.Parse(reader["StatusID"].ToString());
                            item.StatusComment = reader["StatusComment"].ToString();
                            item.StatusName = reader["StatusName"].ToString();
                            item.StatusNameAL = reader["StatusNameAL"].ToString();
                            item.StatusDate = DateTime.Parse(reader["StatusName"].ToString());
                            item.CreatedUser = int.Parse(reader["CreatedUser"].ToString());
                            item.CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString());
                            item.CreatedUserName = reader["CreatedUserName"].ToString();
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
