using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models.CaseHistoryDTO;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LegalOfficeWeb_Models.MainDTO;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class APMainController : Controller
    {
        private readonly IAPMainRepository aPMainRepository;
        public APMainController(IAPMainRepository aPMainRepository)
        {
            this.aPMainRepository = aPMainRepository;

        }
        [HttpPost]
        public async Task<IActionResult> CUDAPMain([FromBody] CUDMainDTO mainDTO)
        {
            try
            {
                var result = await aPMainRepository.CUDMain(mainDTO);
                return Ok(new SuccessModelDTO()
                {
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = ex.Message
                });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAPMain([FromQuery] MainDataDTO mainDataDTO)
        {
            if (mainDataDTO.CaseId == null || mainDataDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await aPMainRepository.GetMain(mainDataDTO);
            if (cases == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }
            return Ok(cases);
        }
    }
}
