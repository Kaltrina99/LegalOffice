using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LegalOfficeWeb_Models.ManualPaymentDTO;

namespace LegalOfficeWeb_API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class ManualPaymentController : Controller
    {
        private readonly IManualPaymentRepository manualPaymentRepository;
        public ManualPaymentController(IManualPaymentRepository manualPaymentRepository)
        {
            this.manualPaymentRepository = manualPaymentRepository;

        }


        [HttpPost]
        public async Task<IActionResult> CUDRLCase([FromBody] CUDManualPaymentDTO manualPaymentDTO)
        {
            try
            {
                //var result = 
                    await manualPaymentRepository.CUDManualPayment(manualPaymentDTO);
                if (manualPaymentDTO.ProcessType == 1)
                {
                    return Ok();
                }
                return Ok(new SuccessModelDTO()
                {
                    StatusCode= 200,
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
    }
}
