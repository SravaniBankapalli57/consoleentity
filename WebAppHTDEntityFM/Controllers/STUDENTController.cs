using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class STUDENTController : Controller
    {
        private readonly DBCONTEXT _context;
        public STUDENTController(DBCONTEXT context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddData(STUDENT obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "STUDENT");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            var res = from s in _context.SSTUDENT
                      where s.SName.StartsWith("S") && s.Branch == "CSE"
                      select s;
            return View(res.ToList());
        }
        [HttpGet]
        public IActionResult update(int? SID)
        {
            if (SID == null)
            {
                return NotFound();
            }
            var data = _context.SSTUDENT.Find(SID);
            return View(data);
        }
        public IActionResult update(int SID, STUDENT STUDENT)
        {
            if (ModelState.IsValid)
            {
                _context.Update(STUDENT);
                _context.SaveChanges();
                return RedirectToAction("Display", "STUDENT");
            }
            return View();
        }

        public IActionResult Delete(int? SID)
        {
            var result = _context.SSTUDENT.Find(SID);
            if (result != null)
            {
                _context.SSTUDENT.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "STUDENT");
            }
            return View();
        }
    }
}
