namespace Back_BookMySport.Models;

public class Session
{
    private bool _available;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MaxBooking { get; set; }

    public bool Available
    {
        get
        {
            return _available;
        }
        set
        {
            if (Bookings.Count == MaxBooking)
            {
                _available = false;
            }
        }
    } 
    public string ImagePath { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}