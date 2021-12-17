using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using productsandcategories.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace ProductAndCatagories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
        //
        [HttpGet("")]
        public IActionResult Products()
        {
            Products product = new Products()
            {
                AllProducts = _context.Products.ToList()
            };
            return View (product);
        }
        //
        [HttpPost("newproduct")]
        public IActionResult newProduct(Products fromForm)
        {
        if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

            return RedirectToAction("Products");
            }
            else
            {
            return View("Products");
            }
        }
        //
        [HttpGet("products/{productId}")]
        public IActionResult Productsaddcat(int productId)
        {
            Productview prodview = new Productview()
            {
            ToRender = _context.Products
            .Include(p => p.AssignedCategories)
            .ThenInclude(a => a.CatwithProd)
            .FirstOrDefault(p => p.ProductId == productId),

            ToAdd = _context.Categories
            .Include(c => c.AssignedProducts)
            .Where(a => !a.AssignedProducts.Any(cat => cat.ProductId == productId)).ToList()
            };
            return View(prodview);
        }


        [HttpPost("add/products/{productId}")]
        public IActionResult addCategroy(int productId, Productview fromForm)
        {
            if(ModelState.IsValid)
            {
                Associations cat = fromForm.AddCategory;
                _context.Add(cat);
                _context.SaveChanges();

            return RedirectToAction("Productsaddcat", new{ProductId = productId});
            }
            return View("Productsaddcat");
        }


//Categories Section


        [HttpGet("categories")]
        public IActionResult Categories()
        {
            Categories category = new Categories()
            {
                AllCategories = _context.Categories.ToList()
            };
            return View (category);
        }

        [HttpPost("newcategory")]
        public IActionResult newCategory(Categories fromForm)
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


        [HttpGet("category/{categoryId}")]
        public IActionResult CategoryView(int categoryId)
        {
            Categoryview catview = new Categoryview()
            {
                ToRender = _context.Categories
                .Include(p => p.AssignedProducts)
                .ThenInclude(a => a.ProdwithCat)
                .FirstOrDefault(p => p.CategoryId == categoryId),

                ToAdd = _context.Products
                .Include(c => c.AssignedCategories)
                .Where(c => !c.AssignedCategories.Any(cat => cat.CategoryId == categoryId))
                .ToList()
            };

        return View("CategoryView");
        }


        [HttpPost("add/category/{categoryId}")]
        public IActionResult addProduct(int categoryId, Categoryview viewModel)
        {
            if(ModelState.IsValid)
            {
                Associations fromFrom = viewModel.AddForm;
                _context.Add(fromFrom);
                _context.SaveChanges();

                return RedirectToAction("Cate", new {CategoryId = categoryId});
            }
            else 
            {
            return CategoryView(categoryId);
            }
        }
    }
}
