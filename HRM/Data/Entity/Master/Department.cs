using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Department", Schema = "HR")]
    public class Department
    {
        public string deptCode { get; set; }

        [Required]
        public string deptName { get; set; }
        public string deptNameBn { get; set; }

        public string shortName { get; set; }

    }
}
