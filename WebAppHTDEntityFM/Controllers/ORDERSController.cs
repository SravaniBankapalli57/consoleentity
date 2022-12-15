using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{

    public class ORDERSController : Controller
    {
        private readonly DBCONTEXT _context;
        public ORDERSController(DBCONTEXT context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(ORDERS obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "ORDERS");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            var res = from s in _context.SORDERS
                      orderby s.CustomerID ascending
                      select s;
            return View(res.ToList());
        }
        [HttpGet]
        public IActionResult update(int? OrderID)
        {
            if (OrderID == null)
            {
                return NotFound();
            }
            var data = _context.SORDERS.Find(OrderID);
            return View(data);
        }
        public IActionResult update(int OrderID, ORDERS ORDERS)
        {
            if (ModelState.IsValid)
            {
                _context.Update(ORDERS);
                _context.SaveChanges();
                return RedirectToAction("Display", "ORDERS");
            }
            return View();
        }

        public IActionResult Delete(int? OrderID)
        {
            var result = _context.SORDERS.Find(OrderID);
            if (result != null)
            {
                _context.SORDERS.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "ORDERS");
            }
            return View();
        }
    }
    
}

