using Microsoft.AspNetCore.Mvc;

namespace VitalRegistrationSystem.Controllers
{
    public class DivorceController : Controller
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
