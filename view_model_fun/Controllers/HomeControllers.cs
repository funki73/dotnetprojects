using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace view_model_fun    //be sure to use your own project's namespace!
{
    public class HomeController : Controller
    {
        public List<User> CreateUsers()
        {
            return new List<User>()
            {
                new User(){ Name="Moose"},
                new User(){ Name="Sarah"},
                new User(){ Name="Jerry"},
                new User(){ Name="Rene"},
                new User(){ Name="Barbarah"}
            };
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string stringModel = "My message is here, this is a simple string that I am using as a model";

            return View("Index", stringModel);
        }

        [HttpGet("users")]    
        public IActionResult Users()
        {
            var users = CreateUsers();
            return View(users);
        }
    }
}