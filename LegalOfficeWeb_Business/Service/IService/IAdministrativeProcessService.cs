using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service.IService
{
    public interface IAdministrativeProcessService
    {
        public Task<IEnumerable<AdministrativeProcessDTO>> GetAll();
    }
}
