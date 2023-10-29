namespace Back_BookMySport.Models;

public class Gym
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Session> OpenSessions { get; set; }

}

