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
    public class AdministrativeProcessRepository : IAdministrativeProcessRepository
    {
        private readonly BaseRepository baseRepo;
        public AdministrativeProcessRepository(IOptions<DatabaseSettings> dbOptions)
        {
            DatabaseSettings dbSettings = dbOptions.Value;
            baseRepo = new BaseRepository(dbSettings.DefaultConnection);
        }


      
    }
}
