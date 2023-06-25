using Microsoft.AspNetCore.Mvc;
using VitalRegistrationSystem.Data;
using VitalRegistrationSystem.Models;

namespace VitalRegistrationSystem.Controllers
{
    public class DeathController : Controller
    {
        private readonly VRSDbContext _db;

        public DeathController(VRSDbContext db)
        {
            _db = db;
        }

        //Read
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<DeathModel> deathObj = _db.Deaths.ToList();
            return View(deathObj);
        }

        //Create operation

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDeath(DeathModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Deaths.Add(obj);
                _db.SaveChanges();
                //TempData["success"] = "Category created sucessfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Update operation

        [HttpGet]
        public IActionResult Update(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.Deaths.FirstOrDefault(u => u.DeathId == id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDeath(DeathModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Deaths.Update(obj);
                _db.SaveChanges();
                //TempData["success"] = "Category Updated sucessfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Delete operation 
        [HttpGet]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deathGuidFromDb = _db.Deaths.FirstOrDefault(u => u.DeathId == id);
            if (deathGuidFromDb == null)
            {
                return NotFound();
            }
            return View(deathGuidFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDeath(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _db.Deaths.FirstOrDefault(u => u.DeathId == id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Deaths.Remove(obj);
            _db.SaveChanges();
            //TempData["success"] = "Category Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
