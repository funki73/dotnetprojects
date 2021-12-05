using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using view_model_fun.Models;

namespace view_model_fun.Controllers
{
    public class HomeController : Controller
    {
        public List<Username> CreateUsers()
        {
            return new List<Username>()
            {
                new Username(){ name ="Moose"},
                new Username(){ name ="Sarah"},
                new Username(){ name ="Jerry"},
                new Username(){ name ="Rene"},
                new Username(){ name ="Barbarah"}
            };
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            string stringModel = "Beep, Bop, Boop";

            return View("Index", stringModel);
        }

        [HttpGet("userlist")]
        public IActionResult Userlist()
        {
            var users = CreateUsers();
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            var rand = new Random();
            var users = CreateUsers();

            var user = users[rand.Next(users.Count)];
            return View(user);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]{4,5,-7, 100, 125};
            return View(numbers);
        }
    }
}