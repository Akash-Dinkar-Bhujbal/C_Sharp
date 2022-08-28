using Microsoft.AspNetCore.Mvc;
using MVC_CRUDInOne.Models;
using System.Diagnostics;

namespace MVC_CRUDInOne.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View("Index");
        }

        

        [HttpPost]
        public IActionResult AddEmp(Employee obj)
        {

            var context = new EmployeeContext();
            context.Employee.Add(obj);
            context.SaveChanges();

            ViewBag.Result = "Record inserted";
            return View("Index");
        }

        
        [HttpPost]
        public IActionResult DisplayEmp(Employee obj)
        {
            var context = new EmployeeContext();
            obj = context.Employee.Find(obj.Id);

            if (obj == null)

                ViewBag.Result = "Record Not Found";
            else
                ViewBag.Result = obj.Id + " " + obj.Name + " " + obj.Address + " " + obj.Age;

            return View("Index");
        }

        /*DisplayAll Not Working*/
        public IActionResult DisplayAll()
        {
            var context = new EmployeeContext();
            IEnumerable<Employee> emp = context.Employee.ToList();
            ViewBag.ResultAll = emp;
            return View("Index");
        }

        

        [HttpPost]
        public IActionResult UpdateEmp(Employee obj)
        {
            var context = new EmployeeContext();
            Employee emp = context.Employee.Find(obj.Id);

            if (emp == null)
                ViewBag.Work = "Record Not Found";
            else
            {
                emp.Name = obj.Name;
                emp.Address = obj.Address;
                emp.Age = obj.Age;
                context.SaveChanges();

                ViewBag.Result = "Record updated";
            }


            return View("Index");
        }

        

        [HttpPost]
        public IActionResult DeleteEmp(Employee obj)
        {
            var context = new EmployeeContext();
            obj = context.Employee.Find(obj.Id);

            if (obj == null)
                ViewBag.Result = "Record Not Found";
            else
            {
                context.Employee.Remove(obj);
                context.SaveChanges();

                ViewBag.Result = "Record Deleted";
            }
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }



       
    }
}