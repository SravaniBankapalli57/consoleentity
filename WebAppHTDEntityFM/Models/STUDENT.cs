using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class STUDENT
    {
        [Key]
        public int SID { get; set; }
        public string RollNo { get; set; }
        public string SName { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }
        public int DeptNo { get; set; }
        public string EmailID { get; set; }
        public int Fee { get; set; }
    }
}
