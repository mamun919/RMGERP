using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Nominee", Schema = "HR")]
    public class Nominee: Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string name { get; set; }

        [MaxLength(150)]
        public string address { get; set; }

        [MaxLength(100)]
        public string relation { get; set; }

        [MaxLength(100)]
        public string contact { get; set; }

        [MaxLength(100)]
        public string nid { get; set; }

        [MaxLength(100)]
        public string brn { get; set; }

        [MaxLength(100)]
        public string imageUrl { get; set; }
    }
}
