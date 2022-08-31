using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

        }
        [HttpGet]
        public async Task<IActionResult> SearchCustomer([FromQuery] SearchCustomerDTO searchCustomerDTO)
        {
            try
            {
                return Ok(await customerRepository.SearchCustomer(searchCustomerDTO));
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
        public async Task<IActionResult> CustomerName([FromQuery] CustomerNameDTO customerNameDTO)
        {
            try
            {
                return Ok(await customerRepository.CustomerName(customerNameDTO));
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
