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
                AllChefs = _context.Chefs.Include(chef => chef.CreatedDishes).ToList(),
                AllDishes = _context.Dishes.Include(dish => dish.Creator).ToList()
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
            Dish dishes = new Dish
            {
                AllChefs = _context.Chefs.ToList()
            };
            return View("newdishes", dishes);
        }

        [HttpPost("/newdish/add")]
        public IActionResult Newdishes(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

            return RedirectToAction("dishes");
            }
            else
            {
            return Newdishes();
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