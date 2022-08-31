using LegalOfficeWeb_Business.Repository.IRepository;
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
    public class UsersRepository: IUsersRepository
    {
        private readonly BaseRepository baseRepo;
        public UsersRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }

        public void AddUsers(UserDTO userDTO)
        {
            using (var con = baseRepo.GetConnection())
            {

                using (var cmd = new SqlCommand("dbo.HMRB_trn_IUDUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prp_UserID", userDTO.UserId);
                    cmd.Parameters.AddWithValue("@prp_UserName", userDTO.UserName);
                    cmd.Parameters.AddWithValue("@prp_CreatedUserID", userDTO.CreatedUser);
                    cmd.Parameters.AddWithValue("@prp_Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@prp_Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@prp_PhoneNr", userDTO.PhoneNumber);
                    cmd.Parameters.AddWithValue("@prp_FullName", userDTO.FullName);
                    cmd.Parameters.AddWithValue("@prp_RoleIDs", userDTO.RoleIds);
                    cmd.Parameters.AddWithValue("@prp_UserType", userDTO.UserType);
                    cmd.Parameters.AddWithValue("@prp_ProcessType", 1);
  
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void DeleteUsers(UserDTO userDTO)
        {
            using (var con = baseRepo.GetConnection())
            {

                using (var cmd = new SqlCommand("dbo.HMRB_trn_IUDUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prp_UserID", userDTO.UserId);
                    cmd.Parameters.AddWithValue("@prp_UserName", userDTO.UserName);
                    cmd.Parameters.AddWithValue("@prp_CreatedUserID", userDTO.CreatedUser);
                    cmd.Parameters.AddWithValue("@prp_Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@prp_Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@prp_PhoneNr", userDTO.PhoneNumber);
                    cmd.Parameters.AddWithValue("@prp_FullName", userDTO.FullName);
                    cmd.Parameters.AddWithValue("@prp_RoleIDs", userDTO.RoleIds);
                    cmd.Parameters.AddWithValue("@prp_UserType", userDTO.UserType);
                    cmd.Parameters.AddWithValue("@prp_ProcessType", 3);
                
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            using (var con = baseRepo.GetConnection())
            {

                using (var cmd = new SqlCommand("dbo.spGetAllUsers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var reader = cmd.ExecuteReader();
                    var items = new List<UserDTO>();
                    if (reader != null && reader.HasRows)
                    while (reader.Read())
                    {
                        var item = new UserDTO();
                        item.UserId = int.Parse(reader["UserID"].ToString());
                        item.UserName = reader["UserName"].ToString();
                        item.FullName= reader["FullName"].ToString();
                        item.Email = reader["Email"].ToString();
                        items.Add(item);
                    }
            
                con.Close();
                    return items;
                }
            }
        }

        public UserDTO GetUsersDatail(int? id)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.User_GetByID", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.CommandTimeout = 600;
                        var reader = cmd.ExecuteReader();
                        if (reader == null || !reader.HasRows)
                            return null;
                        var item = new UserDTO();
                        while (reader.Read())
                        {
                            item.UserId = int.Parse(reader["UserID"].ToString());
                            item.UserName = reader["UserName"].ToString();
                            item.FullName = reader["FullName"].ToString();
                            item.Email = reader["Email"].ToString();
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

        public void UpdateUsers(UserDTO userDTO)
        {
            using (var con = baseRepo.GetConnection())
            {

                using (var cmd = new SqlCommand("dbo.HMRB_trn_IUDUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prp_UserID", userDTO.UserId);
                    cmd.Parameters.AddWithValue("@prp_UserName", userDTO.UserName);
                    cmd.Parameters.AddWithValue("@prp_CreatedUserID", userDTO.CreatedUser);
                    cmd.Parameters.AddWithValue("@prp_Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@prp_Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@prp_PhoneNr", userDTO.PhoneNumber);
                    cmd.Parameters.AddWithValue("@prp_FullName", userDTO.FullName);
                    cmd.Parameters.AddWithValue("@prp_RoleIDs", userDTO.RoleIds);
                    cmd.Parameters.AddWithValue("@prp_UserType", userDTO.UserType);
                    cmd.Parameters.AddWithValue("@prp_ProcessType", 2);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
