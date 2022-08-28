using AspCompareString.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspCompareString.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string str1, string str2)
        {
            if (str1 == str2)
                ViewBag.result = "Both Strings are Equal";
            else
                ViewBag.result = "Both Strings are not Equal";

            return View();
        }


    }
}