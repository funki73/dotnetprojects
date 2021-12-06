using System;
using System.ComponentModel.DataAnnotations;
using validating_form_submission;

namespace validating_form_submission.Controllers
{
    public class Form
    {
        [Display(Name = "First Name:")]
        [Required]
        public string FirstName {get;set;}

        [Display(Name = "Last Name:")]
        [Required]
        public string LastName {get;set;}
        
        [Display(Name = "Age:")]
        [Range(0, 100)]
        public int Age {get;set;}
        
        [Display(Name = "Email Address:")]
        [EmailAddress]
        [Required]
        public string Emailaddress {get;set;}
        
        [Display(Name = "Password:")]
        [Required]
        public string Password {get;set;}

        public Form(string firstname, string lastname, int age, string emailaddress, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Emailaddress = emailaddress;
            Password = password;
        }
    }
}

