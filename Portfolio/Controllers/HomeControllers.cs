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
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string name, string emailinfo, string message)
        {
            Name = name;
            Emailinfo = emailinfo;
            Message = message;
        }
    }
}
