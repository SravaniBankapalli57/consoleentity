using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace WebAppHTDEntityFM.Models
{
    public class PRODUCTMODEL
    {
        [Key]
        public int PID { get; set; }
        public string PRONAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime EXPIRYDATE { get; set; }
        public decimal PRICE { get; set; }
    }
}
