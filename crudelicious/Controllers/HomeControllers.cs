	using System;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

namespace crudelicious.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}