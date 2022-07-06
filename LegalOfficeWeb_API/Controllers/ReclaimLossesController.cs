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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLCase(reclaimLossesCaseDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLCase(reclaimLossesCaseDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLCase(reclaimLossesCaseDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLCaseHistory(reclaimLossesCaseHistoryDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLCaseHistory(reclaimLossesCaseHistoryDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLCaseHistory(reclaimLossesCaseHistoryDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLCaseNotification([FromBody] ReclaimLossesCaseNotificationDTO reclaimLossesCaseNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLCaseNotification(reclaimLossesCaseNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLCaseNotification([FromBody] ReclaimLossesCaseNotificationDTO reclaimLossesCaseNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLCaseNotification(reclaimLossesCaseNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLCaseNotification([FromBody] ReclaimLossesCaseNotificationDTO reclaimLossesCaseNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLCaseNotification(reclaimLossesCaseNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLAgreement([FromBody] ReclaimLossesAgreementDTO reclaimLossesAgreementDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLAgreement(reclaimLossesAgreementDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLAgreement([FromBody] ReclaimLossesAgreementDTO reclaimLossesAgreementDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLAgreement(reclaimLossesAgreementDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLAgreement([FromBody] ReclaimLossesAgreementDTO reclaimLossesAgreementDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLAgreement(reclaimLossesAgreementDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLAgreementNotification([FromBody] ReclaimLossesAgreementNotificationDTO reclaimLossesAgreementNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLAgreementNotification(reclaimLossesAgreementNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLAgreementNotification([FromBody] ReclaimLossesAgreementNotificationDTO reclaimLossesAgreementNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLAgreementNotification(reclaimLossesAgreementNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLAgreementNotification([FromBody] ReclaimLossesAgreementNotificationDTO reclaimLossesAgreementNotificationDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLAgreementNotification(reclaimLossesAgreementNotificationDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
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
        //[HttpPost]
        //public async Task<IActionResult> CreateRLManualPayment([FromBody] ReclaimLossesManualPaymentDTO reclaimLossesManualPaymentDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.CreateRLManualPayment(reclaimLossesManualPaymentDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateRLManualPayment([FromBody] ReclaimLossesManualPaymentDTO reclaimLossesManualPaymentDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.UpdateRLManualPayment(reclaimLossesManualPaymentDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteRLManualPayment([FromBody] ReclaimLossesManualPaymentDTO reclaimLossesManualPaymentDTO)
        //{
        //    try
        //    {
        //        var result = await reclaimLossesRepository.DeleteRLManualPayment(reclaimLossesManualPaymentDTO);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = result
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
        #endregion
    }
}
