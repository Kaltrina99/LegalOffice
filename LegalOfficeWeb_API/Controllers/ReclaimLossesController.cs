using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    [AllowAnonymous]
    public class ReclaimLossesController : Controller
    {
        private readonly IReclaimLossesRepository reclaimLossesRepository;
        public ReclaimLossesController(IReclaimLossesRepository reclaimLossesRepository)
        {
            this.reclaimLossesRepository = reclaimLossesRepository;

        }

        #region RLCases
        [HttpPost]
        public async Task<IActionResult> CUDRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLCase(reclaimLossesCaseDTO);
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
        public async Task<IActionResult> GetAllRLCase()
        {
                return Ok(await reclaimLossesRepository.GetAllRLCases());      
        }
        [HttpGet]
        public async Task<IActionResult> GetRLCase([FromHeader]int id)
        {
            return Ok(await reclaimLossesRepository.GetRLCase(id));
        }
        #endregion

        #region RLCaseHistory
        [HttpPost]
        public async Task<IActionResult> CUDRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLCaseHistory(reclaimLossesCaseHistoryDTO);
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
        #endregion

        #region RLCaseNotification
        [HttpPost]
        public async Task<IActionResult> CUDRLCaseNotification([FromBody] ReclaimLossesCaseNotificationDTO reclaimLossesCaseNotificationDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLCaseNotification(reclaimLossesCaseNotificationDTO);
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
        #endregion

        #region RLAgreement
        [HttpPost]
        public async Task<IActionResult> CUDRLAgreement([FromBody] ReclaimLossesAgreementDTO reclaimLossesAgreementDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLAgreement(reclaimLossesAgreementDTO);
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
        
        #endregion

        #region RLAgreementNotification
        [HttpPost]
        public async Task<IActionResult> CUDRLAgreementNotification([FromBody] ReclaimLossesAgreementNotificationDTO reclaimLossesAgreementNotificationDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLAgreementNotification(reclaimLossesAgreementNotificationDTO);
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

        #endregion

        #region RLManualPayment
        [HttpPost]
        public async Task<IActionResult> CUDRLManualPayment([FromBody] ReclaimLossesManualPaymentDTO reclaimLossesManualPaymentDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CUDRLManualPayment(reclaimLossesManualPaymentDTO);
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
       
        #endregion
    }
}
