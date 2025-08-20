using FinalProject.Context;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FinalProject.Controllers
{
    public class CategoryController : Controller
    {
        
        MyContext db = new MyContext();
        
        // Index => List All Departments
        [HttpGet]
        public IActionResult Index()
        {
            var categories = db.Categories;
            return View(categories);
        }
        
        // View Details => View Details Of a Specific Department
        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = db.Categories.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        
        // Create - Get Method To Show The View That Contain Form 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        // Create - Post Method To Send Data To Server
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // Edit - Get Method To Show The View That Contain Form 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null)
            {
                return RedirectToAction("Index");
            }
            return View(cat);
        }
        
        // Edit - Post Method To Send Data To Server
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}

