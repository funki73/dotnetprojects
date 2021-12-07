using System;
using validating_form_submission.Models;
using Microsoft.AspNetCore.Mvc;

namespace validating_form_submission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("submit")]
        public ViewResult Submitted(Form user)
        {
            if(ModelState.IsValid)
            {
                return View("Submitted");
            }
            return View("Index");
        }

        [HttpGet("submitted")]

        public ViewResult Success()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}