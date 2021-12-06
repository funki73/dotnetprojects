	using System;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

namespace dojodachi
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