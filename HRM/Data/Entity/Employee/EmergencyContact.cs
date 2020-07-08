using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("EmergencyContact", Schema = "HR")]
    public class EmergencyContact:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string name { get; set; }

        [MaxLength(100)]
        public string relation { get; set; }

        [MaxLength(100)]
        public string designation { get; set; }

        [MaxLength(100)]
        public string organization { get; set; }

        [MaxLength(100)]
        public string contact { get; set; }

        [MaxLength(100)]
        public string email { get; set; }
    }
}
