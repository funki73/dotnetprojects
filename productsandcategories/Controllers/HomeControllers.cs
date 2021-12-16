using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using productsandcategories.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProductAndCatagories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Products(int productId)
        {
            Productview ViewModel = new Productview
            {
                ToRender = _context.Products.Include(p => p.AllCategories).ThenInclude(a => a.Category).FirstOrDefault(p => p.ProductId == productId),
                ToAdd = _context.Categories.Include(c => c.AllProducts).Where(a => !a.AllProducts.Any( cat => cat.ProductId == productId)).ToList()
            };
            return View(ViewModel);
        }

        [HttpPost("/addproduct")]
        public IActionResult addProduct(Products fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

            return RedirectToAction("Products");
            }
            else
            {
            return View("Index");
            }
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.ListCategories = _context.Categories
            return View();
        }

        [HttpPost("addcategory")]
        public IActionResult addCategory(Categories fromForm)
            {
            Console.WriteLine("Hello From Category");
            if(ModelState.IsValid)
                {
                    _context.Add(fromForm);
                    _context.SaveChanges();

                    return RedirectToAction("categories");
            }
            else
            {
                return View("categories");
            }
        }
    }
}