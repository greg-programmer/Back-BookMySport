namespace Back_BookMySport.Models;

public class Gym
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Street { get; set; }

    public string ZipCode { get; set; }
    public string City { get; set; }
    public List<Session> OpenSessions { get; set; }

}

