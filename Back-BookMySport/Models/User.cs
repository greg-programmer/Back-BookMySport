using System.ComponentModel.DataAnnotations;

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
        [RegularExpression(@"[^0-9]")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        [RegularExpression(@"[^0-9]")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
