using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("EmployeeType", Schema = "HR")]
    public class EmployeeType 
    {
        [Required]
        public string empType { get; set; }
        public string empTypeBn { get; set; }

        public string shortName { get; set; }
    }
}
