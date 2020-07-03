using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Photograph", Schema = "HR")]
    public class Photograph 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        [Required]
        public string url { get; set; }

        public string remarks { get; set; }

        [Required]
        public string type { get; set; }

    }
}
