using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class ADDCOUNTRYController : Controller
    {
        private readonly DBCONTEXT _context;
        public ADDCOUNTRYController(DBCONTEXT context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCountry(COUNTRYSTATE OBJ)
        {
            COUNTRY objcountry = new COUNTRY();
            objcountry.CNAME = OBJ.CNAME;
            _context.Country.Add(objcountry);
            _context.SaveChanges();

            STATE objstate = new STATE();
            objstate.SNAME = OBJ.SNAME;
            objstate.CID = objcountry.CID;
            _context.State.Add(objstate);
            _context.SaveChanges();
            return View();
        }
    }
}
