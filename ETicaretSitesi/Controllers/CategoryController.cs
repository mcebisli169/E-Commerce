using ETicaretSitesi.Context;
using ETicaretSitesi.Models;
using ETicaretSitesi.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ETicaretSitesi.Controllers
{
    public class CategoryController : Controller
    {
        MyDbContext _db;
        IRepository<Category> _repoCategory;
        public CategoryController(MyDbContext db, IRepository<Category> repoCategory)
        {
            _db = db;
            _repoCategory = repoCategory;
        }
        public IActionResult CategoryList()
        {
            List<Category> categories =_repoCategory.GetAll().Where(s=>s.Status== Enums.RecordStatus.Active).ToList();
           // List<Category> categories = _db.Categories.Where(a => a.Status != Enums.RecordStatus.Deleted).ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAddModel model)
        {
            Category category = new Category();
            category.CategoryName = model.CategoryName;
            category.Description = model.Description;
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public IActionResult Edit(int id)
        {
            Category category = _repoCategory.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _repoCategory.Update(category);
            return RedirectToAction("CategoryList");
        }
        public IActionResult Delete(int id)
        {
            _repoCategory.Delete(id);
            return RedirectToAction("CategoryList");
        }
    }
}
