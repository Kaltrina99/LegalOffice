using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IUsersRepository
    {
        public IEnumerable<UserDTO> GetAllUsers();
        public void AddUsers(UserDTO userDTO);
        public void UpdateUsers(UserDTO userDTO);
        public UserDTO GetUsersDatail(int? id);
        public void DeleteUsers(UserDTO userDTO);
    }
}
