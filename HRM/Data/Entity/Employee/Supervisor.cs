using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Supervisor", Schema = "HR")]
    public class Supervisor 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? supervisorId { get; set; }
        public EmployeeInfo supervisor { get; set; }

        public string commandOrder { get; set; }
        public string canFinalApprover { get; set; }
    }
}
