using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using onetomany.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace onetomany
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> dishesWithUser = dbMyContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();
            return View(dishesWithUser);
        }

        [HttpGet("/dishes")]
        public ViewResult Dishes()
        {
            return View();
        }

        [HttpGet("/newdishes")]
        public ViewResult Newdishes()
        {
            return View();
        }

        [HttpPost("/newdish/add")]
        public IActionResult Newdish(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("newdishes", new{ dishId = fromForm.DishId});
            }
        else
            {
                return View("newdishes");
            }
        }

        [HttpGet("/newchef")]
        public ViewResult Newchef()
        {
            return View();
        }

        [HttpPost("/newchef/add")]
        public IActionResult Newchefs(Chef fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("newchef", new{ chefId = fromForm.ChefId});
            }
        else
            {
                return View("newchef");
            }
        }
    }
}