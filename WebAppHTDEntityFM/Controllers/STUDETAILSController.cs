using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class STUDETAILSController : Controller
    {
        private readonly DBCONTEXT _context;
        public STUDETAILSController(DBCONTEXT context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult StuDet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StuDet(STUDENTDETAILS OBJ)
        {
            STUD objstudent = new STUD();
            objstudent.SNAME = OBJ.SNAME;
            objstudent.ROLLNO = OBJ.ROLLNO;
            _context.student.Add(objstudent);
            _context.SaveChanges();

            DEP objdep = new DEP();
            objdep.DEPNAME = OBJ.DEPNAME;
            objdep.DEPNO = OBJ.DEPNO;
            objdep.SID = objstudent.SID;
            _context.deptartment.Add(objdep);
            _context.SaveChanges();

            SFEE objfee = new SFEE();
            objfee.STUFEE = OBJ.STUFEE;
            _context.studentfee.Add(objfee);
            objfee.SID = objstudent.SID;
            _context.SaveChanges();
            return View();
        }
    }
}
