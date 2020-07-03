using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Supervisor", Schema = "HR")]
    public class Supervisor 
    {
        public int employeeID { get; set; }
        public EmployeeInfo employee { get; set; }

        public int? supervisorId { get; set; }
        public EmployeeInfo supervisor { get; set; }

        public string commandOrder { get; set; }
        public string canFinalApprover { get; set; }
    }
}
