using FinalProject.Context;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class ProductController : Controller
    {
        MyContext db = new MyContext();
        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products;
            return View(products);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = db.Products.Include(e => e.Category).FirstOrDefault(e => e.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var existId = db.Products.FirstOrDefault(e => e.ProductId == product.ProductId);
            if (existId!= null)
            {
                ModelState.AddModelError("", "Product Already Exist");
                ViewBag.CategoryList = new SelectList(db.Categories, "CategoryId", "Name");
                return View();
            }

            // Ignore Validation Category
            ModelState.Remove("Category");
            if (product != null && ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "All Fields required");
            ViewBag.CategoryList = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        // Edit - Get Method To Show The View That Contain Form 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pro = db.Products.Find(id);
            if (pro == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.CategoryList = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
            return View(pro);
        }
        
        // Edit - Post Method To Send Data To Server
        [HttpPost]
        public IActionResult Edit(Product pro)
        {
            db.Products.Update(pro);
            db.SaveChanges();
            ViewBag.CategoryList = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }

}

