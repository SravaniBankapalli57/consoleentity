using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class EMPLOYController : Controller
    {
        private readonly DBCONTEXT _context;
        public EMPLOYController(DBCONTEXT context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(EMPLOY obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "EMPLOY");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            return View(_context.SEMPLOY.ToList());
        }
        [HttpGet]
        public IActionResult update(int? EmpID)
        {
            if (EmpID == null)
            {
                return NotFound();
            }
            var data = _context.SEMPLOY.Find(EmpID);
            return View(data);
        }
        public IActionResult update(int EmpID, EMPLOY EMPLOY)
        {
            if (ModelState.IsValid)
            {
                _context.Update(EMPLOY);
                _context.SaveChanges();
                return RedirectToAction("Display", "EMPLOY");
            }
            return View();
        }

        public IActionResult Delete(int? EmpID)
        {
            var result = _context.SEMPLOY.Find(EmpID);
            if (result != null)
            {
                _context.SEMPLOY.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "EMPLOY");
            }
            return View();
        }
    }
}
