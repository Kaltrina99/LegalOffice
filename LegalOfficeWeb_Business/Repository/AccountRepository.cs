using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Common.Helpers;
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
    public class AccountRepository : IAccountRepository
    {
        private readonly BaseRepository baseRepo;
        public AccountRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public User GetByID(int id)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.User_GetByID", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", id);

                        var reader = cmd.ExecuteReader();
                        if (reader == null || !reader.HasRows)
                            return null;

                        var item = new User();
                        while (reader.Read())
                        {

                            item.UserId = int.Parse(reader["UserId"].ToString());
                            item.UserName = reader["UserName"].ToString();
                            item.FullName = reader["FullName"].ToString();
                            item.Email = reader["Email"].ToString();
                            item.PhoneNr = reader["PhoneNr"].ToString();
                            item.EmpId = int.Parse(reader["EmpId"].ToString());
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
