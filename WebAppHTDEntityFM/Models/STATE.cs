using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppHTDEntityFM.Models
{
    public class STATE
    {
        [Key]
        [ForeignKey("Country")]
        public int CID { get; set; }
        public String SNAME { get; set; }
        public virtual COUNTRY Country { get; set; }
    }
}
