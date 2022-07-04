using LegalOfficeWeb_Business.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdministrativeProcessController : Controller
    {
        private readonly AdministrativeProcessService administrativeProcessService;
        public AdministrativeProcessController(AdministrativeProcessService administrativeProcessService)
        {
            this.administrativeProcessService = administrativeProcessService;

        }
        //[HttpGet]
        //[AllowAnonymous]
        //public async Task<IEnumerable<IActionResult>> GetAll()
        //{
        //    return (IEnumerable<IActionResult>)await administrativeProcessService.GetAll();
        //}
    }
}
