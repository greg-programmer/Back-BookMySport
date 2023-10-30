using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Back_BookMySport.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(30)]
        //[RegularExpression(@"[^a-z]")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        //[RegularExpression(@"[^a-z]")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
