using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.CustomerDTO;
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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BaseRepository baseRepo;
        public CustomerRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }

        public async Task<IEnumerable<NameHistoryDTO>> CustomerName(CustomerNameDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.HMRB_get_CustomerNames", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
                        cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
                        cmd.Parameters.AddWithValue("@prp_ProcessTypeID", objDTO.ProcessTypeId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();

                        var items = new List<NameHistoryDTO>();
                        while (await reader.ReadAsync())
                        {
                            var item = new NameHistoryDTO();
                            item.CustomerName = reader["CustomerName"].ToString();
                            item.UpdateDate = reader["UpdateDate"].ToString();
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

        public async Task<CustomerResponseDTO> SearchCustomer(SearchCustomerDTO objDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.HMRB_get_SearchCustomer", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_AgencyID", objDTO.AgencyId);
                        cmd.Parameters.AddWithValue("@prp_UserID", objDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_EldebitorID", objDTO.EldebitorId);
                            cmd.Parameters.AddWithValue("@prp_AMeterID", objDTO.AMeterId);
                        cmd.CommandTimeout = 600;
                        var reader = await cmd.ExecuteReaderAsync();


                        var item = new CustomerResponseDTO();
                        while (await reader.ReadAsync())
                        {
                            item.AgencyId =reader["AgencyId"].ToString();
                            item.EldebitorId = int.Parse(reader["EldebitorId"].ToString());
                            item.CustomerName = reader["ConsumerName"].ToString();
                            item.MeterAddress = reader["MeterAddress"].ToString();
                            item.TariffGroupId = reader["TariffGroupId"].ToString();
                            item.PhoneNumber = reader["PhoneNumber"].ToString();
                            item.PersonalNo = reader["PersonalNo"].ToString();
                            item.SubDistrict = reader["SubDistrict"].ToString();
                            item.AMeterId = int.Parse(reader["AMeterId"].ToString());
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
