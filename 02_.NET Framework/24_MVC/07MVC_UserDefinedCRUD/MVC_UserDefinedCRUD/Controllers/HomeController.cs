using Microsoft.AspNetCore.Mvc;
using MVC_UserDefinedCRUD.Models;
using MVC3_ORM.Models;
using System.Diagnostics;

namespace MVC_UserDefinedCRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            //Employee obj = new Employee();
            //obj.Name = "Akash";
            //obj.Age = 25;

            //var context = new EmployeeContext();
            //context.Employee.Add(obj);
            //context.SaveChanges();

            //ViewBag.Work = "Record inserted";
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee obj)
        {

            var context = new EmployeeContext();
            context.Employee.Add(obj);
            context.SaveChanges();

            ViewBag.Work = "Record inserted";
            return View();
        }

        [HttpGet]
        public IActionResult DisplayEmp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayEmp(Employee obj)
        {
            var context = new EmployeeContext();
            obj = context.Employee.Find(obj.Id);

            if (obj == null)
                
                ViewBag.Work = "Record Not Found";
            else
                ViewBag.Work = obj.Id + " " + obj.Name + " " + obj.Address + " " + obj.Age;

            return View();
        }

        public IActionResult DisplayAll()
        {
            var context = new EmployeeContext();
            IEnumerable<Employee> emp = context.Employee.ToList();

            return View(emp);
        }

        [HttpGet]
        public IActionResult UpdateEmp()
        {
            return View();
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

                ViewBag.Work = "Record updated";
            }
            

            return View();
        }

        [HttpGet]
        public IActionResult DeleteEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteEmp(Employee obj)
        {
            var context = new EmployeeContext();
            obj = context.Employee.Find(obj.Id);

            if (obj == null)
                ViewBag.Work = "Record Not Found";
            else
            {
                context.Employee.Remove(obj);
                context.SaveChanges();

                ViewBag.Work = "Record Deleted";
            }
            return View();
        }

    }
}