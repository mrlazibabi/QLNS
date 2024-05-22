
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QLNS.Models.AuthenModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AccountsController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("SignIn")]
        public IActionResult SignIn(SignIn signin)
        {
            if(signin.Role == 0)
            {
                var role = "Admin";
                var token = GenerateJwtToken(signin.Email, role);
                return Ok(new { Token = token });
            }
            else if (signin.Role == 3)
            {
                var role = "Employee";
                var token = GenerateJwtToken(signin.Email, role);
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized();
            }
        }
        private string GenerateJwtToken(string email, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_config["JWT:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }


}
