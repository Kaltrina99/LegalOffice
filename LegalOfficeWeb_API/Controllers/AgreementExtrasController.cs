using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LegalOfficeWeb_Models.AgreementExtrasDTO;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class AgreementExtrasController : Controller
    {
        private readonly IAgreementExtrasRepository agreementExtrasRepository;
        public AgreementExtrasController(IAgreementExtrasRepository agreementExtrasRepository)
        {
            this.agreementExtrasRepository = agreementExtrasRepository;

        }

        [HttpGet]
        public async Task<IActionResult> AgreementNotification([FromQuery] AgreementFilterDataDTO objDTO)
        {
            try
            {
                return Ok(await agreementExtrasRepository.AgreementNotification(objDTO));
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
        public async Task<IActionResult> AgreementInvoices([FromQuery] AgreementFilterDataDTO objDTO)
        {
            try
            {
                return Ok(await agreementExtrasRepository.AgreementInvoices(objDTO));
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
        public async Task<IActionResult> AgreemeentInvoicePayments([FromQuery] AgreementFilterDataDTO objDTO)
        {
            try
            {
                return Ok(await agreementExtrasRepository.AgreemeentInvoicePayments(objDTO));
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
        public async Task<IActionResult> AgreementInstallmentResponseDTOs([FromQuery] AgreementFilterDataDTO objDTO)
        {
            try
            {
                return Ok(await agreementExtrasRepository.AgreementInstallmentResponseDTOs(objDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = ex.Message
                });
            }
        }
    }
}
