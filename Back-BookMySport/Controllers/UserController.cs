using Back_BookMySport.DTOS;
using Back_BookMySport.Helpers;
using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Back_BookMySport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;      
        private readonly ILogin _login;
        private readonly Settings _settings;

        public UserController(IUser user, ILogin login, IOptions<Settings> optionAppSettings)
        {
            _user = user;
            _login = login;
            _settings =optionAppSettings.Value;
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequestDTO userDTO)
        {
            if (await _user.Create(userDTO))
            {
                return Ok("Utilisateur créé !");
            }
            return BadRequest("Email existant !");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
             var userConnected = await _login.Login(email, password);
            if (userConnected != null)
            {
                List<Claim> claims = new List<Claim>()
            {
              new Claim("UserId", userConnected.Id.ToString())// on peut ajouter l'Id de l'utilisateur en Claim
            };
                    SigningCredentials signingCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.SecretKey)),
                    SecurityAlgorithms.HmacSha256
                );

                JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: _settings.ValidIssuer,
                    audience: _settings.ValidAudience,
                    claims: claims,
                    signingCredentials: signingCredentials,
                    expires: DateTime.Now.AddDays(7)
                    );

                string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                return Ok(new
                {
                    Token = token,
                    Message = "Authentication Successfull !!!",
                    User = userConnected.Id,
                });
                }
            return Unauthorized();              
        }       
    }
}
