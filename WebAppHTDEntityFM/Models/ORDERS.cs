using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class ORDERS
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
    }
}

