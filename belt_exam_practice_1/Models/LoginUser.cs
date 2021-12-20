using System.ComponentModel.DataAnnotations;

namespace belt_exam
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Please enter your email.")]
        public string LogEmail { get; set; }

        [Required(ErrorMessage = "You must enter a password")]
        public string LogPassword { get; set; }

    }
}