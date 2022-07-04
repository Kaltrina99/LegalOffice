using LegalOfficeWeb_API.Helper;
using LegalOfficeWeb_Business.Repository.IRepository;
using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Common.Helpers;
using LegalOfficeWeb_DataAccess.Data;
using LegalOfficeWeb_Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LegalOfficeWeb_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly LegalOfficeWeb_Common.Helpers.IAuthenticationService authenticationService;
        private readonly IAccountRepository accountRepository;
        private readonly APISettings _aPISettings;
        public AccountController(LegalOfficeWeb_Common.Helpers.IAuthenticationService authenticationService, IAccountRepository accountRepository, IOptions<APISettings> options)
        {
            this.authenticationService = authenticationService;
            this.accountRepository = accountRepository;
            _aPISettings = options.Value;
        }
       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LogInRequestDTO model)
        {
                if (model == null || !ModelState.IsValid)
                {
                    return BadRequest();
                }
                var checkLdap = authenticationService.LDAPLogin(model.Username.ToLower(), model.Password);
                int.TryParse(model.Username.ToLower().Replace("keds", "").Replace("kesco", ""), out int userId);

                var user = accountRepository.GetByID(userId);
                if (user == null)
                {
                    return Unauthorized(new LogInResponseDTO
                    {
                        IsAuthSuccessful = false,
                        ErrorMessage = "Invalid Authentication"
                    });
                }

               
                var signinCredentials = GetSigningCredentials();
                var claims = await GetClaims(user);
                var tokenOptions = new JwtSecurityToken(
                  issuer: _aPISettings.ValidIssuer,
                  audience: _aPISettings.ValidAudience,
                  claims: claims,
                  expires: DateTime.Now.AddDays(30),
                  signingCredentials: signinCredentials);

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new LogInResponseDTO()
                {
                    IsAuthSuccessful = true,
                    Token = token,
                    UserDTO = new UserDTO()
                    {
                        Name = user.FullName,
                        Id = user.UserId.ToString(),
                        Email = user.Email,
                        PhoneNumber = user.PhoneNr,
                        EmpId=user.EmpId.ToString(),
                    }
                });
          
        }
       
        private SigningCredentials GetSigningCredentials()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_aPISettings.SecretKey));

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.EmpId > 60000 ? "keds" + user.EmpId : "kesco" + user.EmpId),
                new Claim(ClaimTypes.GivenName,user.FullName),
                new Claim("Id",user.EmpId.ToString())
            };

      

            return claims;
        }

    }
}
