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
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == user.Email))
                {
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Index");
                }
                else
                { 
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    _context.Add(user);
                    _context.SaveChanges();

                    HttpContext.Session.SetInt32("UserId", user.UserId);
                    return RedirectToAction ("Success");
                }
            }   
            else
            {
            return View("Index");
            }
        }

        public IActionResult Method(User user)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                
                _context.SaveChanges();
            }
            return View("Index");
        }

        [HttpGet("login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost("me")]
        public IActionResult Logins(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.Email);

                if(userInDb == null)
                {
                        ModelState.AddModelError("Email", "Invalid Email/Password");
                        return View("login");
                }
                    
                    var hasher = new PasswordHasher<LoginUser>();
                    
                    var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                    
                    if(result == 0)
                    {
                        ModelState.AddModelError("Password", "Invalid Email/Password");
                        return View("login");
                    }
                }
        HttpContext.Session.SetInt32("UserId", userSubmission.UserId);
        return View("success");
        }

        [HttpGet("Success")]
        public IActionResult Sucess()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
                return View();
        }
    }
}