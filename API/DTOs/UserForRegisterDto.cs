using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        // [StringLength(8, MinimumLength = 4, ErrorMessage =
        //     "Password must be at least 4 characters!")]
        public string Password { get; set; }
        // [Required]
        public string KnownAs { get; set; }
        // [Required]
        public DateTime DateOfBirth { get; set; }
        // [Required]
        public string City { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string IpAdress { get; set; }
        public string Token { get; set; }


        public UserForRegisterDto(){
            Created = DateAndTime.Now;
            LastActive = DateAndTime.Now;
        }
    }
}