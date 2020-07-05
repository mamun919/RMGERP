using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Nominee", Schema = "HR")]
    public class Nominee
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string name { get; set; }
        public string address { get; set; }
        public string relation { get; set; }
        public string contact { get; set; }
        public string nid { get; set; }
        public string brn { get; set; }
        public string imageUrl { get; set; }
    }
}
