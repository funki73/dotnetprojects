using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registration_login.Models
{
    public class LoginUser
    {
        [Key]
        public int UserId { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set;}

        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        }
}