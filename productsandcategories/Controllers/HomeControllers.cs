using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProductAndCatagories.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]       //type of request
        public string Index()
        {
            return "Hello World from HelloController!";
        }
    }
}