using System;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey_with_models.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("/survey/submission")]
        public ViewResult SurveySubmission(Survey fromForm)
        {
            // Survey toRender = new Survey(name, favoritelanguage, dojolocation, comments);

            return View(fromForm);
        }
    }
}