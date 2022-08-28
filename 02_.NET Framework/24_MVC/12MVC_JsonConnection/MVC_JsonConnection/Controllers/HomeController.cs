using Microsoft.AspNetCore.Mvc;
using MVC_JsonConnection.Models;
using System.Diagnostics;

namespace MVC_JsonConnection.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails()
        {
            try
            {
                UserDataModel model = new UserDataModel();
                model.Name = HttpContext.Request.Form["txtName"].ToString();
                model.Age = Convert.ToInt32(HttpContext.Request.Form["txtAge"]);
                model.City = HttpContext.Request.Form["txtCity"].ToString();
                int result = model.SaveDetails();
                if (result > 0)
                    ViewBag.Result = "Data Saved Sucessfully";
                else
                    ViewBag.Result = "Something Went Wrong";
            }
            catch
            {
                ViewBag.Result = "Something Went Wrong";
            }
            
            return View("Profile");
        }

       
    }
}