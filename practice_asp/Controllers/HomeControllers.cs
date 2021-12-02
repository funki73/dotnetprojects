using System;
using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.MyName = "Dude";
            ViewBag.FavoriteVegetable = "Brussel Sprouts";

            return View();
        }

        [HttpGet("hello")] //localhost:5000/hello
        public string Hello()
        {
            return "Hi Again!";
        }

        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "Seattle")
                return $"Hello {username} from {location}.  Go Seahawks!";
            return $"Hello {username} from {location}.";
        }
    }
}
