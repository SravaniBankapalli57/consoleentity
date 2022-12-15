using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class ITEMSController : Controller
    {

        private readonly DBCONTEXT _context;
        public ITEMSController(DBCONTEXT context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddItems()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItems(ITEMS obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "ITEMS");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            return View(_context.SITEMS.ToList());
        }
        [HttpGet]
        public IActionResult update(int? ItemID)
        {
            if (ItemID == null)
            {
                return NotFound();
            }
            var data = _context.SITEMS.Find(ItemID);
            return View(data);
        }
        [HttpPost]
        public IActionResult update(int ItemID, ITEMS ITEMS)
        {
            if (ModelState.IsValid)
            {
                _context.Update(ITEMS);
                _context.SaveChanges();
                return RedirectToAction("Display", "ITEMS");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? ItemID)
        {
            var result = _context.SITEMS.Find(ItemID);
            if (result != null)
            {
                _context.SITEMS.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "ITEMS");
            }
            return View();
        }
    }
}
