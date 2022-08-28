using Microsoft.AspNetCore.Mvc;
using MVC2.Models;
using System.Diagnostics;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        
        // ActionMethod
        public IActionResult Index()
        {
            ViewData["msg"] = "Welcome";
            ViewData["var1"] = DateTime.Now.ToString();
            string[] arr = { "David", "Raj", "Rahim", "John"};
            ViewData["var2"] = arr;
            List<string> cities = new List<string>();
            cities.Add("Mumbai");
            cities.Add("Delhi");
            cities.Add("Banglore");
            ViewData["var3"] = cities;
            Employee o = new Employee();
            o.age = 11;
            o.name = "maya";
            o.address = "Delhi";
            ViewData["var4"] = o;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.x = "Delhi";
            ViewData["y"] = "Noida";
            TempData["z"] = "Welcome";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }


    }
}