using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Reference", Schema = "HR")]
    public class Reference:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(50)]
        public string name { get; set; }

        [MaxLength(50)]
        public string designation { get; set; }

        [MaxLength(100)]
        public string organization { get; set; }

        [MaxLength(30)]
        public string contact { get; set; }

        [MaxLength(40)]
        public string email { get; set; }
    }
}
