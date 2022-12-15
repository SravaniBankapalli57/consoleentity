using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class COUNTRY
    {
        [Key]
        public int CID { get; set; }
        public String CNAME { get; set; }
        public virtual  STATE State { get; set; }
    }
}
