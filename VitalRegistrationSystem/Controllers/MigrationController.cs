using Microsoft.AspNetCore.Mvc;

namespace VitalRegistrationSystem.Controllers
{
    public class MigrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
