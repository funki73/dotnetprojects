	using System;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using crudelicious.Models;

namespace crudelicious
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("New")]
        public ViewResult New()
        {
            return View();
        }

        [HttpPost("/surveysubmission")]
        public IActionResult SurveySubmission(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                return View(fromForm);
            }
        else
            {
                return View("Index");
            }
        }
    }
}