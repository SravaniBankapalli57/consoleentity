using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class ITEMS
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemColor { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime PurchasedDate { get; set; }

    }
}
