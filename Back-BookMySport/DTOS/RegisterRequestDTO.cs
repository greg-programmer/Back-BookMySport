using System.ComponentModel.DataAnnotations;

namespace Back_BookMySport.DTOS
{
    public class RegisterRequestDTO
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
