using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IAccountService
    {
        Task<LogInResponseDTO> Login(LogInRequestDTO signInRequestDTO);
        Task Logout();
    }
}
