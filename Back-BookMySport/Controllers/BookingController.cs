using AutoMapper;
using Back_BookMySport.DTOs;
using Back_BookMySport.Models;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Mvc;

namespace Back_BookMySport.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IRepository<Booking> _bookingService;
    private readonly IRepository<Session> _sessionService;
    private readonly IMapper _mapper;

    public BookingController(IRepository<Booking> bookingService,IRepository<Session> sessionService, IMapper mapper)
    {
        _bookingService = bookingService;
        _mapper = mapper;
        _sessionService = sessionService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Booking> bookings = await _bookingService.GetAll();
        
        return Ok(bookings);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] BookingDTO bookingDTO,int sessionId)
    {
        Booking booking = _mapper.Map<Booking>(bookingDTO);
        Session session = await _sessionService.GetById(sessionId);
        booking.SessionId = session.Id;
        

        int createdAtId = await _bookingService.Add(booking);
        if (createdAtId > 0)
        {
            return Ok(new
            {
               Message = "Booking added",
               Booking = booking
            });
        }
        return NotFound("Bad Request");
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (await _bookingService.Delete(id))
            return Ok("Booking Deleted");
        return NotFound("Booking Not Found");
    }
}