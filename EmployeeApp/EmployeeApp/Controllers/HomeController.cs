using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["FirstValue"] = "Hello World";
            ViewData["SecondValue"] = "Hello ViewData";
            ViewData["ThirdValue"] = "How are you!";

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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
