	using System;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using crudelicious.Models;
    using System.Linq;

namespace crudelicious
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("newdish")]
        public ViewResult NewDish()
        {
            return View();
        }

        [HttpPost("/newdish/create")]
        public IActionResult NewDish(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();
                return View("Show");
            }
        else
            {
                return View();
            }
        }
        // [HttpGet("/show/{dishId}")]
        // public IActionResult Show(int dishId)
        // {
        //     Dish toRender = _context.Dishes.FirstOrDefault( dish => dish.DishId == dishId);

        //     return View(toRender);
        //     ****new{ dishId = fromForm.DishId})
        // }
    }
}