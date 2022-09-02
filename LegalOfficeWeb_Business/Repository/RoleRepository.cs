using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
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
        public RoleRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }
        public async Task<RoleDTO> CUDUserRole(UserRoleDTO userRoleDTO)
        {
            try
            {
                using (var con = baseRepo.GetConnection())
                {
                    using (var cmd = new SqlCommand("dbo.HMRB_trn_IUDUserRole", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prp_UserID", userRoleDTO.UserId);
                        cmd.Parameters.AddWithValue("@prp_CreatedUserID", userRoleDTO.CreatedUserId);
                        cmd.Parameters.AddWithValue("@prp_RoleIDs", userRoleDTO.RoleIds);
                         await cmd.ExecuteReaderAsync();

                        con.Close();
                        return new RoleDTO()
                        {
                        };
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
