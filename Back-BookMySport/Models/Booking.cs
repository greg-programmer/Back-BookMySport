namespace Back_BookMySport.Models;

public class Booking
{
    public int Id { get; set; }
    public DateTime BookDate { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    
}