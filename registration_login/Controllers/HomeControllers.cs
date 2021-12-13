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
                    _context.Add(user);
                    _context.SaveChanges();
                    return View("Sucess");
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

        [HttpGet("Login")]
        public ViewResult Login()
        {
            return View();
        }
    }
}