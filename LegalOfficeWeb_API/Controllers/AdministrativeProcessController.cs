using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Business.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdministrativeProcessController : Controller
    {
        private readonly IAdministrativeProcessRepository administrativeProcessRepository;
        public AdministrativeProcessController(IAdministrativeProcessRepository administrativeProcessRepository)
        {
            this.administrativeProcessRepository = administrativeProcessRepository;

        }
       
    }
}
