using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using random_passcode.Models;

namespace random_passcode
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null)
            {
            HttpContext.Session.SetInt32("Count", 1);
            }
            int? count = HttpContext.Session.GetInt32("Count");

            ViewBag.Count = count;
            ViewBag.Code = TempData["newCode"];
            // Passcode toRender = new Passcode ((int) count);

            GenerateCode();
            Console.WriteLine(count);
            return View();
        }

        [HttpGet("increment")]
        public IActionResult Increment()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count++;
            HttpContext.Session.SetInt32("Count", (int) count);

            return RedirectToAction("Index");
        }

        public void GenerateCode()
        {
            Increment();

            string library = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] charArr = library.ToCharArray();
            Random rand = new Random();
            char[] passArr = new char[14];
            for(int idx = 0; idx < passArr.Length; idx++)
            {
                passArr[idx] = charArr[rand.Next(35)];
            }

            TempData["newCode"] = new string(passArr);
        }
    }
}