using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IUsersServices
    {
        public Task<IEnumerable<UserDTO>> GetAllUsers();
        public void AddUsers(UserDTO userDTO);
        public void UpdateUsers(UserDTO userDTO);
        public Task<UserDTO> GetUsersDatail(int? id);
        public void DeleteUsers(UserDTO userDTO);
    }
}
