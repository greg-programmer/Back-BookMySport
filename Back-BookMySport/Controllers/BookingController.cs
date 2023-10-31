using AutoMapper;
using Back_BookMySport.DTOs;
using Back_BookMySport.DTOS;
using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Back_BookMySport.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IRepository<Booking> _bookingService;
    private readonly IRepository<Session> _sessionService;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<User> _userManager;

    public BookingController(IRepository<Booking> bookingService, IRepository<Session> sessionService, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
    {
        _bookingService = bookingService;
        _sessionService = sessionService;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _userManager = userManager;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAll(string userId)
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        string userConnected = identity.FindFirst("UserId").Value;
        if (userConnected != userId)
        {
            return Forbid();
        }
        List<Booking> bookings = await _bookingService.GetAll();
        List<BookingDTO> bookingDtos = _mapper.Map<List<BookingDTO>>(bookings);
        
        return Ok(bookingDtos);
    }

    [Authorize]
    [HttpGet("BookingsFromUser")]
    public async Task<IActionResult> GetAllFromUser(string userId)
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        string userConnected = identity.FindFirst("UserId").Value;
        if (userConnected != userId)
        {
            return Forbid();
        }
        List<Booking> bookings = await _bookingService.GetAllFromUser(userId);

        return Ok(bookings);
    }
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Post(string userId, int sessionId)
    {
        //var identity = HttpContext.User.Identity as ClaimsIdentity;
        //string userConnected = identity.FindFirst("UserId").Value;
        //if (userConnected != userId)
        //{
        //    return Forbid();
        //}
        Booking booking = new Booking();
        booking.UserId = userId;
        booking.SessionId = sessionId;
        //Session session = await _sessionService.GetById(sessionId);      
        int createdAtId = await _bookingService.Add(booking);
        BookingDTO bookingDTO  = _mapper.Map<BookingDTO>(booking);

        if (createdAtId > 0)
        {
            BookingDTO bookingDto = _mapper.Map<BookingDTO>(booking);
            return Ok(new
            {
               Message = "Booking added",
               Booking = bookingDTO
            });
        }
        
        
        return NotFound("Bad Request");
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
        if (await _bookingService.Delete(id))
            return Ok("Booking Deleted");
        return NotFound("Booking Not Found");
    }
}