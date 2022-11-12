using ETicaretSitesi.Context;
using ETicaretSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ETicaretSitesi.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext _db;
        public ProductController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult ProductList()
        {
            List<Product> products = _db.Products.Include(s=>s.Category).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.CategoryList = _db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("ProductList");
        }
       

    }
}
