﻿using System.ComponentModel.DataAnnotations;

namespace Back_BookMySport.DTOS
{
    public class RegisterRequestDTO
    {
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
