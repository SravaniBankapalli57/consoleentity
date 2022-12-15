using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppHTDEntityFM.Models
{
    public class SFEE
    {
        [Key]
        [ForeignKey("student")]
        public int SID { get; set; }
        public int STUFEE { get; set; }
        public virtual STUD student { get; set; }
    }
}
