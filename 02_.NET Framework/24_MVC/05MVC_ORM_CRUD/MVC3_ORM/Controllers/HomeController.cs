using Microsoft.AspNetCore.Mvc;
using MVC3_ORM.Models;
using System.Diagnostics;

namespace MVC3_ORM.Controllers
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
        public IActionResult Display()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Display(int Id)
        {
            var context = new EmployeeContext();
            Employee obj = context.Employee.Find(Id);

            if (obj == null)

                ViewBag.Result = "Record Not Found";
            else
                ViewBag.Result = obj.Id + " " + obj.Name + " " + obj.Address + " " + obj.Age;

            return View();
        }

        public IActionResult DisplayAll()
        {
            var context = new EmployeeContext();
            IEnumerable<Employee> emp = context.Employee.ToList();

            return View(emp);
        }

        [HttpGet]
        public IActionResult UpdateName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateName(int Id,string Name)
        {
            var context = new EmployeeContext();
            Employee obj = context.Employee.Find(Id);

            if (obj == null)
                ViewBag.Result = "Record Not Found";
            else
            {
                obj.Name = Name;
                context.SaveChanges();
                ViewBag.Result = "Updation done";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Employee obj)
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
            return View();
        }


    }
}