using Asp1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp1.Controllers
{
    public class HomeController : Controller
    {
        // Action Method
        /*Print string on browser*/
        public string welcome()
        {
            return "Welcome to Nelito";
        }

        /*Print Employee obj on Index view*/
        //public IActionResult Index()
        //{
        //    Employee emp = new Employee();
        //    emp.Id = 1;
        //    emp.Name = "Maya";
        //    emp.Age = 21;
        //    ViewBag.x = emp.Id;
        //    ViewBag.y = emp.Name;
        //    ViewBag.z = emp.Age;
        //    return View();
        //}

        /*Print Employee obj LIST on Index view*/
        public IActionResult Index()
        {
            List<Employee> ob = new List<Employee>();

            Employee o1 = new Employee();
            o1.Id = 100;
            o1.Name = "ram";
            Employee o2 = new Employee();
            o2.Id = 200;
            o2.Name = "sita";
            Employee o3 = new Employee();
            o2.Id = 300;
            o3.Name = "sita1";

            ob.Add(o1);
            ob.Add(o2);
            ob.Add(o3);

            ViewBag.emps = ob;
            return View();
        }




    }
}