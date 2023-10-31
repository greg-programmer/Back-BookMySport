using System.Text.Json.Serialization;

namespace Back_BookMySport.Models;

public class Session
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MaxBooking { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime FinishTime { get; set; }
    [JsonIgnore]
    public bool Available
    {
        get
        {
            if (Bookings.Count == MaxBooking)
               return  false;

            return true;

        }
       
    } 
    public string? ImagePath { get; set; }

    public int SportCategoryId { get; set; }
    [JsonIgnore]
    public SportCategory? SportCategory { get; set; }
    
    //One-to-many Gyms
    public int GymId { get; set; }

    public Gym? Gym { get; set; }

    //One-to-many bookings
    public List<Booking> Bookings { get; set; }
}