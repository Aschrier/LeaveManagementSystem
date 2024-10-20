using Leavemanagementsystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Leavemanagementsystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(1900, 12, 01)
            };
            return View(data);
        }
    }
}
