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
        [HttpPost("/survey/submission")]
        public ViewResult SurveySubmission(string name, string favoritelanguage, string dojolocation, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Favoritelanguage = favoritelanguage;
            ViewBag.Dojolocation = dojolocation;
            ViewBag.Comments = comments;
            return View();
        }
    }
}