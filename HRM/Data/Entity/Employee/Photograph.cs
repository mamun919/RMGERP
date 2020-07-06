using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Photograph", Schema = "HR")]
    public class Photograph : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [Required, MaxLength(200)]
        public string url { get; set; }

        [Required, MaxLength(50)]
        public string type { get; set; }

    }
}
