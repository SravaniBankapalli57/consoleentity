using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppHTDEntityFM.Models
{
    public class DEP
    {
        [Key]
        [ForeignKey("student")]
        public int SID { get; set; }
        public String DEPNAME { get; set; }
        public int DEPNO { get; set; }
        public virtual STUD student { get; set; }
    }
}
