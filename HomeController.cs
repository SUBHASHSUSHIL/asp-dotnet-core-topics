using Microsoft.AspNetCore.Mvc;
using ViewImportCsHtml.Models;

namespace ViewImportCsHtml.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Student> std = new List<Student>
            {
            new Student {Id = 1, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=202405056},
            new Student {Id = 2, Name = "sandeep Kumar Thakur",Standard = "Graduation",RollNo=20240056},
            new Student {Id = 3, Name = "Ritik Kumar Thakur",Standard = "Graduation",RollNo=20240506},
            new Student {Id = 4, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=20405056}
            };
            return View(std);
        }
        public IActionResult About()
        {
            List<Student> std = new List<Student>
            {
            new Student {Id = 1, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=202405056},
            new Student {Id = 2, Name = "sandeep Kumar Thakur",Standard = "Graduation",RollNo=20240056},
            new Student {Id = 3, Name = "Ritik Kumar Thakur",Standard = "Graduation",RollNo=20240506},
            new Student {Id = 4, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=20405056}
            };
            return View(std);
        }

        public ActionResult Contact()
        {
            List<Student> std = new List<Student>
            {
            new Student {Id = 1, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=202405056},
            new Student {Id = 2, Name = "sandeep Kumar Thakur",Standard = "Graduation",RollNo=20240056},
            new Student {Id = 3, Name = "Ritik Kumar Thakur",Standard = "Graduation",RollNo=20240506},
            new Student {Id = 4, Name = "sushil Kumar Thakur",Standard = "Graduation",RollNo=20405056}
            };
            return View(std);
        }
    }
}
