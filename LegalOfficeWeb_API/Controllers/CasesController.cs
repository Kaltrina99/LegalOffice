using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class CasesController : Controller
    {
        private readonly ICaseRepository caseRepository;
        public CasesController(ICaseRepository caseRepository)
        {
            this.caseRepository = caseRepository;

        }

        [HttpPost]
        public async Task<IActionResult> CUDRLCase([FromBody] CUDCaseDTO caseDTO)
        {
            try
            {
                var result = await caseRepository.CUDRLCase(caseDTO);
                if (caseDTO.ProcessType == 1)
                {
                    return Ok(result);
                }
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
        public async Task<IActionResult> GetAllRLCase([FromQuery] CaseDataDTO caseDataDTO)
        {
            try
            {
                return Ok(await caseRepository.GetAllRLCases(caseDataDTO));
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
        public async Task<IActionResult> GetRLCase([FromQuery] CaseDataDTO caseDataDTO)
        {
            if (caseDataDTO.CaseId == null || caseDataDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await caseRepository.GetRLCase(caseDataDTO);
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
        [HttpGet]
        public async Task<IActionResult> GetRLCaseInput([FromQuery] CaseInputDataDTO caseDataDTO)
        {
            if (caseDataDTO.CaseId == null || caseDataDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await caseRepository.GetRLCaseInputs(caseDataDTO);
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
