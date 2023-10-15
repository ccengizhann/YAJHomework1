﻿using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;
using Productify.Persistance;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
       
        ProductifyDbContext _context;

        public ProductController()
        {
            _context = new();
        }
        public IActionResult GetAll()
        {
            return View(_context.Products.ToList());
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string productName,decimal price, int quantityInStock)
        {
            _context.Products.Add(new(productName, price, quantityInStock));

            _context.SaveChanges();

            return View();
        }
    }
}
