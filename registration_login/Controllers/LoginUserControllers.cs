using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using registration_login.Models;
using Microsoft.AspNetCore.Identity;


namespace registration_login.Controllers
{
    public class LoginController : Controller
    {
        private MyContext _context;
        public LoginController(MyContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
        if(ModelState.IsValid)
        {
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.Email);

                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Someview");
                }

                var hasher = new PasswordHasher<LoginUser>();
                
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                }
        }
        return View("Sucess");
        }
    }
}