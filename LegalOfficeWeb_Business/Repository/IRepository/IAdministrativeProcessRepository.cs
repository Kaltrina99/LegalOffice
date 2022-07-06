using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;

namespace LegalOfficeWeb_Business.Repository.IRepository
{
    public interface IAdministrativeProcessRepository
    {
        public Task<AdministrativeProcessDTO> Update(AdministrativeProcessDTO objDTO);
        public Task<AdministrativeProcessDTO> Get(int id);
        public Task<IEnumerable<AdministrativeProcessDTO>> GetAll();
        public Task<IEnumerable<AdministrativeProcessStatusesDTO>> GetAllStatuses();
    }
}
