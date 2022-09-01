using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LegalOfficeWeb_Models.CaseHistoryDTO;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class CaseHistoryController : Controller
    {
        private readonly ICaseHistoryRepository caseHistoryRepository;
        public CaseHistoryController(ICaseHistoryRepository caseHistoryRepository)
        {
            this.caseHistoryRepository = caseHistoryRepository;

        }
        [HttpPost]
        public async Task<IActionResult> CUDRLCaseHistory([FromBody] CUDCaseHistoryDTO caseHistoryDTO)
        {
            try
            {
                var result = await caseHistoryRepository.CUDRLCaseHistory(caseHistoryDTO);
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
        public async Task<IActionResult> GetRLCaseHistory([FromQuery] CaseHistoryDataDTO caseHistoryDTO)
        {
            if (caseHistoryDTO.CaseId == null || caseHistoryDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await caseHistoryRepository.GetRLCaseHistory(caseHistoryDTO);
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
