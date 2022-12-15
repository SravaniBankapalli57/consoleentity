using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class STUD
    {
        [Key]
        public int SID { get; set; }
        public String SNAME { get; set; }
        public String ROLLNO { get; set; }
        public virtual DEP deptartment { get; set; }

        public virtual SFEE studentfee { get; set; }


    }
}
