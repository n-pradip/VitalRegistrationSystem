﻿using Microsoft.AspNetCore.Mvc;
using VitalRegistrationSystem.Data;
using VitalRegistrationSystem.Models;

namespace VitalRegistrationSystem.Controllers
{
    //[Route("[controller]")]
    public class BirthController : Controller
    {
        private readonly VRSDbContext _db;

        public BirthController(VRSDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        //[Route("/birth/index")]
        public IActionResult Index()
        {
            IEnumerable<BirthModel> birthObj = _db.Births.ToList();
            return View(birthObj);
        }

        //Create operation

        [HttpGet]
        //[Route("/birth/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[Route("/birth/create")]
        public IActionResult CreateBirth(BirthModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Births.Add(obj);
                _db.SaveChanges();
                //TempData["success"] = "Category created sucessfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Update operation

        [HttpGet]
        //[Route("/birth/update/{id:guid}")]
        public IActionResult Update(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.Births.FirstOrDefault(u => u.BirthId == id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Route("/birth/update")]
        public IActionResult UpdateBirth(BirthModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Births.Update(obj);
                _db.SaveChanges();
                //TempData["success"] = "Category Updated sucessfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Delete operation 

        //GET
        [HttpGet]
        //[Route("/birth/delete/{id:guid}")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                Console.WriteLine("1");
                return NotFound();
            }
            var birthGuidFromDb = _db.Births.FirstOrDefault(u => u.BirthId == id);
            Console.WriteLine("2");
            if (birthGuidFromDb == null)
            {
                Console.WriteLine("3");
                return NotFound();
            }
            return View(birthGuidFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //[Route("/birth/delete")]
        public IActionResult DeleteBirth(Guid? id)
        {
            Console.WriteLine("4");
            if (id == null)
            {
                Console.WriteLine("5");
                return NotFound();
            }

            var obj = _db.Births.FirstOrDefault(u => u.BirthId == id);
            if (obj == null)
            {
                Console.WriteLine("6");
                return NotFound();
            }
            Console.WriteLine("7");
            _db.Births.Remove(obj);
            _db.SaveChanges();
            //TempData["success"] = "Category Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
