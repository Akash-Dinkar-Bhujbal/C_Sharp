using AspFactorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspFactorial.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string factnumber)
        {
            int number = Convert.ToInt32(factnumber);
            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            ViewBag.result = "Factorial of " + factnumber + " is " + factorial.ToString();
            return View();
        }
    }
}