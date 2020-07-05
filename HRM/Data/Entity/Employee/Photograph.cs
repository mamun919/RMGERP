using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Photograph", Schema = "HR")]
    public class Photograph 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [Required]
        public string url { get; set; }

        public string remarks { get; set; }

        [Required]
        public string type { get; set; }

    }
}
