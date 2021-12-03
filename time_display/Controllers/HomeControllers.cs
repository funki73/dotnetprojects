using System;
using Microsoft.AspNetCore.Mvc;

namespace time_display     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        // [HttpGet("")]
        // public string DateTime()
        // {

        // }
    }
}