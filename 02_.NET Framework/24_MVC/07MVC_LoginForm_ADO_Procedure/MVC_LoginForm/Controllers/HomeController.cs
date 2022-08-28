using Microsoft.AspNetCore.Mvc;
using MVC_LoginForm.Models;
using System.Diagnostics;

namespace MVC_LoginForm.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            int res = DB.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "You are welcome to Admin Section";
            }
            else
            {
                TempData["msg"] = "Admin id or Password is wrong.!";
            }
            return View();


        }


    }
}