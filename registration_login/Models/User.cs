using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registration_login.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First Name: " )]
        [MinLength(2, ErrorMessage="Password must be 2 characters or longer!")]
        [Required]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name: " )]
        [MinLength(2, ErrorMessage="Password must be 2 characters or longer!")]
        [Required]
        public string LastName { get; set; }
        
        [Display(Name = "Email: " )]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Password: " )]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Required]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        }
}