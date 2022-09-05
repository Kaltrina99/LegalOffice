using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseHistoryDTO;
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
    public class APMainRepository : IAPMainRepository
    {
        private readonly BaseRepository baseRepo;
        public APMainRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<MainResponseDTO> CUDMain(CUDMainDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_trn_IUDMain", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_APMainID", objDTO.APManinId);
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_CompensationAmount", objDTO.CompensationAmount);
                        cmd.Parameters.AddWithValue("@prp_EvaluatedAmount", objDTO.EvaluationAmound);
                        cmd.Parameters.AddWithValue("@prp_OfferedAmount", objDTO.OfferedAmound);
                        cmd.Parameters.AddWithValue("@prp_PaidAmount", objDTO.PaidAmound);
                        cmd.Parameters.AddWithValue("@prp_CreatedComment", objDTO.CreatedComment);
                        cmd.Parameters.AddWithValue("@prp_ProcessType", objDTO.ProcessType);

                        await cmd.ExecuteNonQueryAsync();
                        con.Close();
                        return new MainResponseDTO()
                        {
                            CreatedUser = objDTO.UserId,
                            APManinId = objDTO.APManinId,
                            CaseId = objDTO.CaseId,
                            CompensationAmount = objDTO.CompensationAmount,
                            EvaluationAmound = objDTO.EvaluationAmound,
                            OfferedAmound = objDTO.OfferedAmound,
                            PaidAmound = objDTO.PaidAmound,
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

        public async Task<IEnumerable<MainResponseDTO>> GetMain(MainDataDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_get_Main", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_CaseID", objDTO.CaseId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_APMainID", objDTO.APMainId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var items = new List<MainResponseDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new MainResponseDTO();
                            item.CaseId = int.Parse(reader["CaseID"].ToString());
                            item.APManinId = int.Parse(reader["APManinID"].ToString());
                            item.CompensationAmount = double.Parse(reader["CompensationAmount"].ToString());
                            item.EvaluationAmound = double.Parse(reader["EvaluationAmound"].ToString());
                            item.OfferedAmound = double.Parse(reader["OfferedAmound"].ToString());
                            item.PaidAmound = double.Parse(reader["PaidAmound"].ToString());
                            item.CreatedComment = reader["CreatedComment"].ToString();
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
