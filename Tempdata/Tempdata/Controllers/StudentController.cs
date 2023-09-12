using Microsoft.AspNetCore.Mvc;

namespace Tempdata.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
