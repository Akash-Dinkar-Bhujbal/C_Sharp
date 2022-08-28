using Microsoft.AspNetCore.Mvc;
using MVC_MultipleButtonsInOneView.Models;
using System.Diagnostics;

namespace MVC_MultipleButtonsInOneView.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {
            try
            {
            var a = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
            var b = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.result = a + b;
            }
            catch
            {
                ViewBag.result = "***Wrong Input***";

            }

            return View("Index");
        }


        [HttpPost]
        public IActionResult Minus()
        {
            try
            {
                var a = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
                var b = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.result = a - b;
            }
            catch
            {
                ViewBag.result = "***Wrong Input***";

            }

            return View("Index");
        }


        [HttpPost]
        public IActionResult Multiply()
        {
            try
            {
                var a = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
                var b = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.result = a * b;
            }
            catch
            {
                ViewBag.result = "***Wrong Input***";

            }

            return View("Index");
        }


        [HttpPost]
        public IActionResult Divide()
        {
            try
            {
                var a = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
                var b = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.result = a / b;
            }
            catch
            {
                ViewBag.result = "***Wrong Input***";

            }

            return View("Index");
        }
    }
}