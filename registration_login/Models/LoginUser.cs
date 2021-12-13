using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registration_login.Models
{
    public class LoginUser
    {
        [EmailAddress]
        [Required]
        public string Email { get; set;}

        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Required]
        public string Password { get; set; }
        }
}