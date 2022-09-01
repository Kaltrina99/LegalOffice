using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.AgreementDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class AgreementController : Controller
    {
        private readonly IAgreementRepository agreementRepository;
        public AgreementController(IAgreementRepository agreementRepository)
        {
            this.agreementRepository = agreementRepository;

        }
        [HttpPost]
        public async Task<IActionResult> CUDRLAgreement([FromBody] CUDAgreementDTO agreementDataDTO)
        {
            try
            {
                var result = await agreementRepository.CUDRLAgreement(agreementDataDTO);
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
        public async Task<IActionResult> GetAllRLAgreement([FromQuery] AgreementDataDTO agreementDataDTO)
        {
            try
            {
                return Ok(await agreementRepository.GetAllRLAgreements(agreementDataDTO));
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
        public async Task<IActionResult> GetRLAgreement([FromQuery] AgreementDataDTO agreementDataDTO)
        {
            if (agreementDataDTO.CaseId == null || agreementDataDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await agreementRepository.GetRLAgreement(agreementDataDTO);
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
