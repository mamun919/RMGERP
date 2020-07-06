using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Supervisor", Schema = "HR")]
    public class Supervisor : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? supervisorId { get; set; }
        public EmployeeInfo supervisor { get; set; }

        [MaxLength(100)]
        public string commandOrder { get; set; }

        [MaxLength(100)]
        public string canFinalApprover { get; set; }
    }
}
