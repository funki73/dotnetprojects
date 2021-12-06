using System;
using Microsoft.AspNetCore.Mvc;

namespace random_passcode
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}