using System;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }

        [HttpPost("/contact/submission")]
        public ViewResult ContactMe(string name, string email, string message)
        {
            return View();
        }

    }
}
