using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
     
                //String string Data
                ViewData["Title"] = "Student Details Page";
                ViewData["Header"] = "Student Details";
            Employee1 student = new Employee1()
                {
                    MyProperty = 101,
                    Name = "James",
                };
                //storing Student Data
                ViewData["Student"] = student;
                return View();

        }
    }
}
