using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Department", Schema = "HR")]
    public class Department: Base
    {
        [MaxLength(50)]
        public string deptCode { get; set; }

        [Required, MaxLength(50)]
        public string deptName { get; set; }
        
        [MaxLength(50)]
        public string deptNameBn { get; set; }

        [MaxLength(50)]
        public string shortName { get; set; }

    }
}
