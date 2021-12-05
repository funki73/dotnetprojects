using System;
using validating_form_submission;

namespace validating_form_submission.Controllers
{
    public class Form
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;set;}
        public string Emailaddress {get;set;}
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

