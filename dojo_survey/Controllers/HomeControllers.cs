using System;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey
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