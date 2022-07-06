using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReclaimLossesController : Controller
    {
        private readonly IReclaimLossesRepository reclaimLossesRepository;
        public ReclaimLossesController(IReclaimLossesRepository reclaimLossesRepository)
        {
            this.reclaimLossesRepository = reclaimLossesRepository;

        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {
             
            return Ok(await reclaimLossesRepository.CreateRLCase(reclaimLossesCaseDTO));
        }
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {

            return Ok(await reclaimLossesRepository.UpdateRLCase(reclaimLossesCaseDTO));
        }
        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {

            return Ok(await reclaimLossesRepository.DeleteRLCase(reclaimLossesCaseDTO));
        }
    }
}
