using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("EmployeeType", Schema = "HR")]
    public class EmployeeType : Base
    {
        [Required, MaxLength(50)]
        public string empType { get; set; }

        [MaxLength(50)]
        public string empTypeBn { get; set; }

        [MaxLength(50)]
        public string shortName { get; set; }
    }
}
