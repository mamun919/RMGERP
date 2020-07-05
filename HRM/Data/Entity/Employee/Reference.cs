using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Reference", Schema = "HR")]
    public class Reference
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string name { get; set; }
        public string designation { get; set; }
        public string organization { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
    }
}
