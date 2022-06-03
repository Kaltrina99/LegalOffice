using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_DataAccess.Data;
using Microsoft.Data.SqlClient;
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
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //public List<Role> GetAllRoles()
        //{
        //    try
        //    {
        //        //using (var con = _context.GetConnection())
        //       {using (var connection = new SqlConnection(_context.Database.ConnectionString))
        //        using (var cmd = new SqlCommand("dbo.Roles_GetAll", connection)
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                var reader = cmd.ExecuteReader();
        //                var items = new List<Role>();
        //                if (reader != null && reader.HasRows)
        //                    while (reader.Read())
        //                    {
        //                        var item = new Role();
        //                        item.RoleId = int.Parse(reader["RoleID"].ToString());
        //                        item.RoleName = reader["RoleName"].ToString();
        //                        items.Add(item);
        //                    }
        //                con.Close();
        //                return items;
        //            }
        //       // }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public List<Role> GetAll()
        {
            var role = _context.Roles.AsEnumerable();
            return role.ToList();
        }
    }
}
