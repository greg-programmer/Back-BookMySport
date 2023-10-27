using AutoMapper;
using Back_BookMySport.DTOs;
using Back_BookMySport.Models;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Mvc;

namespace Back_BookMySport.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionController : ControllerBase
{
    private readonly IRepository<Session> _sessionService;
    private readonly IMapper _mapper;

    public SessionController(IRepository<Session> sessionService,IMapper mapper)
    {
        _sessionService = sessionService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Session> sessions = await _sessionService.GetAll();
        
        return Ok(sessions);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (await _sessionService.Delete(id))
            return Ok("Session Deleted");
        return NotFound("Session Not Found");
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
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