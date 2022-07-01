using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Repository
{
    public class AdministrativeProcessRepository : IAdministrativeProcessRepository
    {
        private readonly BaseRepository baseRepo;
        public AdministrativeProcessRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }

        public Task<AdministrativeProcessDTO> Create(AdministrativeProcessDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AdministrativeProcessDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdministrativeProcessDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApStatus>> GetAllStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<ApStatus> GetApStatus(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AdministrativeProcessDTO> Update(AdministrativeProcessDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
