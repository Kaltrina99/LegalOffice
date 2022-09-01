using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IUsersRepository usersRepository;
        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;

        }
        [HttpPost]
        public async Task<IActionResult> AddUsers([FromBody] UserDTO user)
        {
            try
            {
                usersRepository.AddUsers(user);
                return Ok(new SuccessModelDTO()
                {
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
        public async Task<IActionResult> DeleteUsers([FromBody] UserDTO user)
        {
            try
            {
                usersRepository.DeleteUsers(user);
                return Ok(new SuccessModelDTO()
                {
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
        public async Task<IActionResult> UpdateUsers([FromBody] UserDTO user)
        {
            try
            {
                usersRepository.UpdateUsers(user);
                return Ok(new SuccessModelDTO()
                {
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
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var rez = usersRepository.GetAllUsers();
                return Ok(rez);
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
        public async Task<IActionResult> GetUsersDatail(int? id)
        {
            try
            {
                var rez = usersRepository.GetUsersDatail(id);
                return Ok(rez);
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
