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
        List<BookingDTO> bookingDtos = _mapper.Map<List<BookingDTO>>(bookings);
        
        return Ok(bookingDtos);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(int sessionId)
    {
        Booking booking = new Booking()
        {
            BookDate = DateTime.Now
        };
        Session session = await _sessionService.GetById(sessionId);
        if (session == null)
        {
            return NotFound(new
            {
                Message = "There is no session with this Id."
            });
        }
        booking.SessionId = session.Id;

        if (session.Bookings.Count == session.MaxBooking)
        {
            return BadRequest(new
            {
                Message = "This session is complete"
            });
        }
        

        int createdAtId = await _bookingService.Add(booking);
        if (createdAtId > 0)
        {
            BookingDTO bookingDto = _mapper.Map<BookingDTO>(booking);
            return Ok(new
            {
               Message = "Booking added",
               Booking = bookingDto
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