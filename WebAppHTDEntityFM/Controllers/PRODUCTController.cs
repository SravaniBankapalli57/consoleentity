using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class PRODUCTController : Controller
    {
        private readonly DBCONTEXT _context;
        public PRODUCTController(DBCONTEXT context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProducts(PRODUCTMODEL obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "PRODUCT");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            var res = from s in _context.PRODUCT
                      where s.PRICE > 6000 && s.PRICE < 200000
                      select s;
            return View(res.ToList());
        }
        [HttpGet]
        public IActionResult update(int? PID)
        {
            if (PID == null)
            {
                return NotFound();
            }
            var data = _context.PRODUCT.Find(PID);
            return View(data);
        }
        public IActionResult update(int PID, PRODUCTMODEL PRODUCT)
        {
            if (ModelState.IsValid)
            {
                _context.Update(PRODUCT);
                _context.SaveChanges();
                return RedirectToAction("Display", "PRODUCT");
            }
            return View();
        }

        public IActionResult Delete(int? PID)
        {
            var result = _context.PRODUCT.Find(PID);
            if (result != null)
            {
                _context.PRODUCT.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "PRODUCT");
            }
            return View();
        }
    }
  
}
