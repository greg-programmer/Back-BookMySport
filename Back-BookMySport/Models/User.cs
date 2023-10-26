
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Back_BookMySport.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@123g.com$", ErrorMessage = "E-mail invalide.")]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"[a-zA-Z]")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"[a-zA-Z]")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        [RegularExpression(@"[0-9]")]
        public string Phone { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$")]
        //Minimum eight characters, at least one upper case English letter,
        //    one lower case English letter, one number and one special character
        public string Password { get; set; }
    }
}

