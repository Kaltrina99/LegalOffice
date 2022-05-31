using LegalOfficeWeb_Common.Helpers;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;
        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        [HttpGet]
        public string Login()
        {
            var test = "ok";
            return test;
        }

        [HttpPost]
        [AllowAnonymous]
        public string Login([FromForm] Login model)
        {
            try
            {
                var checkLdap = authenticationService.LDAPLogin(model.Username.ToLower(), model.Password);
                int.TryParse(model.Username.ToLower().Replace("keds", "").Replace("kesco", ""), out int userId);


                return model.Username;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
