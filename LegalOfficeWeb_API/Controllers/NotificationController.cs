using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseNotificationDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        private readonly INotificationRepository notificationRepository;
        public NotificationController(INotificationRepository notificationRepository)
        {
            this.notificationRepository = notificationRepository;

        }
        [HttpPost]
        public async Task<IActionResult> CUDRLCaseNotification([FromBody] CUDNotificationDTO reclaimLossesCaseNotificationDTO)
        {
            try
            {
                var result = await notificationRepository.CUDRLCaseNotification(reclaimLossesCaseNotificationDTO);
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
        public async Task<IActionResult> GetRLCaseNotification([FromQuery] NotificationDataDTO reclaimLossesGetCaseNotificationsDTO)
        {
            if (reclaimLossesGetCaseNotificationsDTO.CaseId == null || reclaimLossesGetCaseNotificationsDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await notificationRepository.GetRLCaseNotification(reclaimLossesGetCaseNotificationsDTO);
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
        public async Task<IActionResult> GetRLCaseNotificationInvioce([FromQuery] NotificationDataDTO reclaimLossesGetCaseNotificationsDTO)
        {
            if (reclaimLossesGetCaseNotificationsDTO.CaseId == null || reclaimLossesGetCaseNotificationsDTO.CaseId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await notificationRepository.GetRLCaseNotificationInvioce(reclaimLossesGetCaseNotificationsDTO);
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
