namespace Back_BookMySport.Models;

public class Gym
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Session> OpenSessions { get; set; }
    public List<Commentary> Commentaries { get; set; }
    public SportCategory Sport { get; set; }
}

public enum SportCategory
{
    Boxe,
    Gym,
    Dance,
    Football,
    Basketball,
    Tennis
}