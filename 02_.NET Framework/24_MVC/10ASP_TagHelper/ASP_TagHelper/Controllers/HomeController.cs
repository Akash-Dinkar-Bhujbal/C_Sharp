using ASP_TagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;
using System.Reflection;
using System.Xml.Linq;

namespace ASP_TagHelper.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            List<Student> listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
            return View(listStudents);

        }
        public IActionResult Details(int Id, string name, string branch, string section, string gender)
        {
            var studentDetails = new Student() { StudentId = Id, Name = name, Branch = branch, Section = section, Gender = gender };
            return View(studentDetails);
        }
        


    }
}