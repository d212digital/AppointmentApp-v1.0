using AppointmentApp.Data;
using AppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        // GET-Create
        public IActionResult CreateExpenses()
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.ExpenseTypes.Select(i => new SelectListItem
                { 
                Text = i.ExpenseTypeCode.ToString(),
                Value = i.ExpenseTypeCode.ToString()

            });

            ViewBag.TypeDropDown = TypeDropDown;

            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateExpenses(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Items.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }

}
