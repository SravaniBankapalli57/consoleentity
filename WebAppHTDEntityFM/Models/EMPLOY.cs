using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class EMPLOY
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public string Role { get; set; }
        public string address { get; set; }
        public int Salary { get; set; }

    }
}
