using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public string projects()
        {
            return "These are my projects!";
        }

        [HttpGet("contact")]
        public string contact()
        {
            return $"This is my Contact!";
        }
    }
}
