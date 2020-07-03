using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Nominee", Schema = "HR")]
    public class Nominee
    {
        public int employeeID { get; set; }
        public EmployeeInfo employee { get; set; }

        public string name { get; set; }
        public string address { get; set; }
        public string relation { get; set; }
        public string contact { get; set; }
        public string NID { get; set; }
        public string BRN { get; set; }
        public string imageUrl { get; set; }
    }
}
