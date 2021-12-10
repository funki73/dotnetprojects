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
            List<Dish> dishes = _context.Dishes.OrderByDescending(dish => dish.UpatedAt).ToList();
            // List<Dish> dishes = _context.Dishes.ToList();
            return View(dishes);
        }

        [HttpGet("newdish")]
        public ViewResult NewDish()
        {
            return View();
        }

        [HttpPost("/newdish/create")]
        public IActionResult Show(Dish fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("Show", new{ dishId = fromForm.DishId});
            }
        else
            {
                return View();
            }
        }

        [HttpGet("/newdish/create/{dishId}")]
        public IActionResult Show(int dishId)
        {
            Dish toRender = _context.Dishes.FirstOrDefault( dish => dish.DishId == dishId);
            return View(toRender);
        }


        [HttpGet("/newdish/delete/{dishId}")]
        public RedirectToActionResult DeleteDish(int dishId)
        {
            Dish toDelete = _context.Dishes.FirstOrDefault ( dish => dish.DishId == dishId);
            
            _context.Dishes.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("newdish/edit/{dishId}")]
        public IActionResult Edit(int dishId)
        { 
            Dish toEdit = _context.Dishes.FirstOrDefault ( dish => dish.DishId == dishId);

                if(toEdit == null)
                {
                    return RedirectToAction ("Index");
                }

                return View(toEdit);
        }

        [HttpPost("dish/update/{dishId}")]
        public IActionResult UpdateDish(int dishId, Dish fromForm)
        {
            if(ModelState.IsValid)
            {
                Dish inDb = _context.Dishes.FirstOrDefault ( dish => dish.DishId == dishId);

                inDb.Chef = fromForm.Chef;
                inDb.DishName = fromForm.DishName;
                inDb.NumCalories = fromForm.NumCalories;
                inDb.Tastiness = fromForm.Tastiness;
                inDb.Description = fromForm.Description;

                _context.SaveChanges();

                return RedirectToAction("Show", new { dishId = dishId });
            }
            else
            {
                return View("Edit");
            }
        }
    }
}