using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Back_BookMySport.Models;

public class SportCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Session> Sessions { get; set; }
    
}