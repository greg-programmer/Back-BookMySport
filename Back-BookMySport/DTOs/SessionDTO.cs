using Back_BookMySport.Models;

namespace Back_BookMySport.DTOs;

public class SessionDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int MaxBooking { get; set; }
    public string ImagePath { get; set; }
    public bool Available { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime FinishTime { get; set; }
    
    public SportCategoryDTO SportCategory { get; set; }
    public List<BookingDTO> Bookings { get; set; }
    public GymDTO Gym { get; set; }
}