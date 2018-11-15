using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Furniture_App.Models;
using FurnitureApp.Models;
using FurnitureApp.DAL;

namespace Furniture_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Signup_login()
        {
            ViewData["Message"] = "This is where you will sign-up and login.";

            return View();
        }

        public IActionResult Items()
        {
            ViewData["Message"] = "this is where you will select some items.";

            return View();
        }

        public IActionResult Profile()
        {
            ViewData["Message"] = "This is where your prifle will be after sign-up/login.";

            using(var db = new FurnitureAppContext())
            {
                db.Users.Add(new User
                {
                    userID = 69,
                    userName = "kevin",
                    firstName = "kev",
                    lastName = "parshneasy"
                });
                db.SaveChanges();

                var users = (from u in db.Users
                             orderby u.userID
                             select u).ToList();
                ViewData["Message"] = users.ToString();
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
