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
        public async Task<IActionResult> CreateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CreateRLCase(reclaimLossesCaseDTO);
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
        [HttpPut]
        public async Task<IActionResult> UpdateRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.UpdateRLCase(reclaimLossesCaseDTO);
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
        [HttpDelete]
        public async Task<IActionResult> DeleteRLCase([FromBody] ReclaimLossesCaseDTO reclaimLossesCaseDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.DeleteRLCase(reclaimLossesCaseDTO);
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

        #region RLCaseHistory
        [HttpPost]
        public async Task<IActionResult> CreateRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.CreateRLCaseHistory(reclaimLossesCaseHistoryDTO);
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
        [HttpPut]
        public async Task<IActionResult> UpdateRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.UpdateRLCaseHistory(reclaimLossesCaseHistoryDTO);
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
        [HttpDelete]
        public async Task<IActionResult> DeleteRLCaseHistory([FromBody] ReclaimLossesCaseHistoryDTO reclaimLossesCaseHistoryDTO)
        {
            try
            {
                var result = await reclaimLossesRepository.DeleteRLCaseHistory(reclaimLossesCaseHistoryDTO);
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
