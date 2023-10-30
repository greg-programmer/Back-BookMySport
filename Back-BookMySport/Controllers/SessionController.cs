using AutoMapper;
using Back_BookMySport.DTOs;
using Back_BookMySport.Models;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Back_BookMySport.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionController : ControllerBase
{
    private readonly IRepository<Session> _sessionService;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SessionController(IRepository<Session> sessionService,IMapper mapper, IHttpContextAccessor httpContextAccessor)
    {
        _sessionService = sessionService;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Session> sessions = await _sessionService.GetAll();
        
        return Ok(sessions);
    }
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, string userId)
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        string userConnected = identity.FindFirst("UserId").Value;
        if (userConnected != userId)
        {
            return Forbid();
        }
        if (await _sessionService.Delete(id))
            return Ok("Session Deleted");
        return NotFound("Session Not Found");
    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id, string userId)
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        string userConnected = identity.FindFirst("UserId").Value;
        if (userConnected != userId)
        {
            return Forbid();
        }
        var session = await (_sessionService.GetById(id));

        if (session == null)
            return NotFound(new
            {
                Message = "There is no Session with this Id."
            });

        SessionDTO sessionDto = _mapper.Map<SessionDTO>(session);

        return Ok(new
        {
            Message = "Session found.",
            Session = sessionDto
        });
    }
}