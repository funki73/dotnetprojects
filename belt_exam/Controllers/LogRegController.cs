using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using belt_exam.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;


namespace   belt_exam.Controllers
{
    public class LogRegController : Controller 
    {
        private MyContext _context { get; }

        public LogRegController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(User fromForm)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == fromForm.Email))
                {
                    return Index();
                }

                PasswordHasher<User> hasher = new PasswordHasher<User>();

                fromForm.Password = hasher.HashPassword(fromForm, fromForm.Password);

                _context.Add(fromForm);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", fromForm.UserId);
                return RedirectToAction("Dashboard", "TvShow");
            }
            else 
            {
                return Index();
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser fromForm)
        {
            if(ModelState.IsValid)
            {
                User inDb = _context.Users.FirstOrDefault(u => u.Email == fromForm.LogEmail);

                if(inDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return Index();
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(fromForm, inDb.Password, fromForm.LogPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return Index();
                }

                HttpContext.Session.SetInt32("UserId", inDb.UserId);
                return RedirectToAction("Dashboard", "TvShow");

            }
            else 
            {
                return Index();
            }
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}

        // [HttpGet("placeholder")]
        // public IActionResult Placeholder()
        // {
        //     return View();
        // }