using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Back_BookMySport.Models;

public class Booking
{
    public int Id { get; set; }
    public DateTime BookDate { get; set; }
    public int SessionId { get; set; }
    [JsonIgnore]
    public Session? Session { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    
}