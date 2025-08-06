using FinalProject.Context;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class UserController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                // Check if email already exists
                if (db.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists");
                    return View(model);
                }

                // Create new user
                var user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password
                };

                db.Users.Add(user);
                db.SaveChanges();

                TempData["SuccessMessage"] = "Registration successful! Please log in.";
                return RedirectToAction("Login", "User");
            }

            return View(model);
        }

        // GET: User/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: User/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login model)
        {

            if (ModelState.IsValid)
            {
                // Find user by email and password
                var user = db.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    TempData["SuccessMessage"] = $"Welcome, {user.FirstName}!";
                    return RedirectToAction("Index","Product");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                }
            }

            return View(model);
        }
    }
}

