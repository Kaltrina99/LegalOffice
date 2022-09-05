using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models.MainDTO;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LegalOfficeWeb_Models.HistoryDTO;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class APHistoryController : Controller
    {
        private readonly IAPHistoryRepository aPHistoryRepository;
        public APHistoryController(IAPHistoryRepository aPHistoryRepository)
        {
            this.aPHistoryRepository = aPHistoryRepository;

        }
        [HttpPost]
        public async Task<IActionResult> CUDAPHistory([FromBody] CUDHistoryDTO mainDTO)
        {
            try
            {
                var result = await aPHistoryRepository.CUDAPHistory(mainDTO);
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
        public async Task<IActionResult> GetAPHistory([FromQuery] HistoryDataDTO historyDataDTO)
        {
            if (historyDataDTO.APMainId == null || historyDataDTO.APMainId == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            var cases = await aPHistoryRepository.GetAPHistory(historyDataDTO);
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
