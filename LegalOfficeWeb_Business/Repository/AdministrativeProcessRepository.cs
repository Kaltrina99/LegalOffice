using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_DataAccess.Data;
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
    public class AdministrativeProcessRepository : IAdministrativeProcessRepository
    {
        private readonly BaseRepository baseRepo;
        public AdministrativeProcessRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }


        public Task<AdministrativeProcessDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AdministrativeProcessDTO>> GetAll()
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_Cases_GetAll", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var reader = cmd.ExecuteReader();
                        var items = new List<AdministrativeProcessDTO>();
                        if (reader != null && reader.HasRows)
                            while (reader.Read())
                            {
                                var item = new AdministrativeProcessDTO();
                                item.AphistoryId=int.Parse(reader["APHistoryID"].ToString());
                                item.CaseId = int.Parse(reader["CaseId"].ToString());
                                item.StatusComment = reader["StatusComment"].ToString();
                                item.StatusDate = DateTime.Parse(reader["StatusDate"].ToString());
                                item.CompensationAmount = double.Parse(reader["CompensationAmount"].ToString());
                                item.EvaluatedAmount = double.Parse(reader["EvaluatedAmount"].ToString());
                                item.OfferedAmount = double.Parse(reader["OfferedAmount"].ToString());
                                item.PaidAmount = double.Parse(reader["PaidAmount"].ToString());
                                item.Comment = reader["Comment"].ToString();
                                item.StatusName = reader["StatusName"].ToString();
                                item.StatusNameAl=reader["StatusNameAl"].ToString();
                                item.Active = bool.Parse(reader["active"].ToString());
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

        public async Task<IEnumerable<AdministrativeProcessStatusesDTO>> GetAllStatuses()
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.AP_Statuses_GetAll", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var reader = cmd.ExecuteReader();
                        var items = new List<AdministrativeProcessStatusesDTO>();
                        if (reader != null && reader.HasRows)
                            while (reader.Read())
                            {
                                var item = new AdministrativeProcessStatusesDTO();
                                item.StatusId = int.Parse(reader["StatusID"].ToString());
                                item.StatusName = reader["StatusName"].ToString();
                                item.StatusNameAl = reader["StatusNameAl"].ToString();
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

        public Task<AdministrativeProcessDTO> Update(AdministrativeProcessDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
