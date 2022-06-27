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
    public class RoleRepository : IRoleRepository
    {
        private readonly BaseRepository baseRepo;
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context, IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
            _context = context;
        }
        public List<Role> GetAll()
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.Roles_GetAll", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var reader = cmd.ExecuteReader();
                        var items = new List<Role>();
                        if (reader != null && reader.HasRows)
                            while (reader.Read())
                            {
                                var item = new Role();
                                item.RoleId = int.Parse(reader["RoleID"].ToString());
                                item.RoleName = reader["RoleName"].ToString();
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

        //public List<Role> GetAll()
        //{
        //    var role = _context.Roles.AsEnumerable();
        //    return role.ToList();
        //}
    }
}
