using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeLanguage", Schema = "HR")]
    public class EmployeeLanguage 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(50)]
        public string reading { get; set; }

        [MaxLength(50)]
        public string writing { get; set; }

        [MaxLength(50)]
        public string speaking { get; set; }

        public int? languageId { get; set; }
        public Language language { get; set; }

        [MaxLength(100)]
        public string proficiency { get; set; }
    }
}
