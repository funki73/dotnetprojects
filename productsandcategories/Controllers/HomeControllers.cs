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
        public IActionResult Products()
        {
            Products product = new Products()
            {
                AllProducts = _context.Products.ToList()
            };
            return View (product);
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
            Categories category = new Categories()
            {
                AllCategories = _context.Categories.ToList()
            };
            return View (category);
        }

        [HttpPost("addcategory")]
        public IActionResult addCategory(Categories fromForm)
            {
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

        [HttpGet("products/{productId}")]
        public IActionResult ProductInfo(int productId)
        {
            Productview ViewModel = new Productview()
            {
                ToRender = _context.Products.Include(p => p.).ThenInclude(a => a.CatwithProd).FirstOrDefault(p => p.ProductId == productId),
                ToAdd = _context.Categories.Include(c => c.)
            };

            return View("ProductInfo", ViewModel);
        }
    }
}