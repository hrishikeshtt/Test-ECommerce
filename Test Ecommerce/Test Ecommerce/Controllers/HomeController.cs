﻿using Microsoft.AspNetCore.Mvc;
using Test_Ecommerce.Model;
using Test_Ecommerce.Models;
using Test_Ecommerce.Services.Interfaces;

namespace Test_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(
            IProductService productService
            )
        {
            _productService= productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login loginUser)
        {       
            if(string.Equals(loginUser.UserName,"admin",StringComparison.OrdinalIgnoreCase) &&
                string.Equals(loginUser.Password, "admin", StringComparison.OrdinalIgnoreCase))
                return RedirectToAction("AddProducts","Home",null);
            else
                return RedirectToAction("BuyProducts");
        }

        public IActionResult AddProducts(Product product)
        {
            if(string.IsNullOrEmpty(product.Name))  
                return View();
            else
            {
                _productService.AddProductAsync(product);
                return View(product);
            }
                
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Category = "Clothes",
                    Description = "T shirt",
                    Name ="Lavis",
                    Price = 2000,
                    Rating = 5,
                    Stock = 10,
                    Weight = 10
                },
                new Product
                {
                    Category = "Watches",
                    Description = "Great watch",
                    Name ="Rolex 123",
                    Price = 2000,
                    Rating = 5,
                    Stock = 10,
                    Weight = 10
                },
                new Product
                {
                    Category = "Laptops",
                    Description = "Good working laptop",
                    Name ="HP Elitebook",
                    Price = 2000000,
                    Rating = 5,
                    Stock = 10,
                    Weight = 10
                },
                new Product
                {
                    Category = "LaptopsOne",
                    Description = "Good working laptops",
                    Name ="HP Elitebooker",
                    Price = 20000090,
                    Rating = 4,
                    Stock = 100,
                    Weight = 156
                }
            };
            return View(products);

        }
    }
}
