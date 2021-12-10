using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace login_registration
{
    public class HomeController : Controller
    {
        private MyContext _context;
    
        public HomeController(MyContext context)
        {
            _context = context;
        }
    
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Monster> AllMonsters = _context.Monsters.ToList();
            
            return View();
        }
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}