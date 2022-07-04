using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class AdministrativeProcessService : IAdministrativeProcessService
    {
        private readonly AdministrativeProcessRepository administrativeProcessRepository;
        public AdministrativeProcessService(AdministrativeProcessRepository administrativeProcessRepository)
        {
            this.administrativeProcessRepository = administrativeProcessRepository; 
        }

        public Task<IEnumerable<AdministrativeProcessDTO>> GetAll()
        {
            return administrativeProcessRepository.GetAll();
        }
    }
}
