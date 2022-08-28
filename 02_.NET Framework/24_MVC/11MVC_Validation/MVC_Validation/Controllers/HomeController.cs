using Microsoft.AspNetCore.Mvc;
using MVC_Validation.Models;
using System.Diagnostics;

namespace MVC_Validation.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student obj)
        {
            if (ModelState.IsValid)
            {
                //Logic
            }
            return View();
        }
        
        
    }
}