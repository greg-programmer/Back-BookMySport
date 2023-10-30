using Back_BookMySport.DTOS;
using Back_BookMySport.Helper;
using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
        private readonly IUserService _login;
        private readonly Settings _settings;
        private IHttpContextAccessor _httpContextAccessor;

        public UserController(IUser user, IUserService login, IOptions<Settings> optionAppSettings, IHttpContextAccessor httpContextAccessor)
        {
            _user = user;
            _login = login;
            _settings = optionAppSettings.Value;
            _httpContextAccessor = httpContextAccessor;
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
        public async Task<IActionResult> Login(LoginRequestDTO loginRequestDTO)
        {
            var userConnected = await _login.Login(loginRequestDTO.Email, loginRequestDTO.Password);
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
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(string userId , RegisterRequestDTO registerRequestDTO)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            string userConnected = identity.FindFirst("UserId").Value;
            if (userConnected != userId)
            {
                return Forbid();
            }
         
            if (await _user.Update(userId, registerRequestDTO))
            {
                return Ok("Utilisateur Modifié !");
            };
            return NotFound("Utilisateur est introuvable ou l'email existe déjà !");
            
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetById(string userId)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            string userConnected = identity.FindFirst("UserId").Value;
            if (userConnected != userId)
            {
                return Forbid();
            }
            var user = await _user.GetUser(userId);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
