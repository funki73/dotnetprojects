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


        [HttpPost("/surveysubmission")]
        public ViewResult SurveySubmission(Survey fromForm)
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