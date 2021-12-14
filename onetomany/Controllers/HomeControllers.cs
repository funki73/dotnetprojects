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
        public ViewResult Index()
        {
            IndexView ViewModel = new IndexView
            {
                AllChefs = _context.Chefs.ToList(),
                AllDishes = _context.Dishes.ToList()
            };
            return View(ViewModel);
        }

        [HttpGet("/dishes")]
        public ViewResult Dishes()
        {
            IndexView ViewModel = new IndexView
            {
                AllChefs = _context.Chefs.ToList(),
                AllDishes = _context.Dishes.ToList()
            };
            return View(ViewModel);
        }

        [HttpGet("/newdishes")]
        public ViewResult Newdishes()
        {
            List<Chef> Chefs = _context.Chefs.ToList();
            return View(Chefs);
        }

        [HttpPost("/newdish/add")]
        public IActionResult Newdish(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

                HttpContext.Session.SetInt32("DishId", fromForm.DishId);
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

                HttpContext.Session.SetInt32("ChefId", fromForm.ChefId);
                return RedirectToAction("newchef", new{ chefId = fromForm.ChefId});
            }
        else
            {
                return View("newchef");
            }
        }
    }
}