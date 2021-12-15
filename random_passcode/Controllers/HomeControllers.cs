using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


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
            ViewBag.Passwrd = TempData["newCode"];
            // Passcode toRender = new Passcode ((int) count);

            GenerateCode();
            return View("Index");
        }

        [HttpGet("increment")]
        public IActionResult Increment()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count = count++;
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
            for(int pw = 0; pw < passArr.Length; pw++)
            {
                passArr[pw] = charArr[rand.Next(35)];
            }

            TempData["newCode"] = new string(passArr);
        }
    }
}