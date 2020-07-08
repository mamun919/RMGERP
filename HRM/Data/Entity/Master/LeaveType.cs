using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("LeaveType", Schema = "HR")]
    public class LeaveType : Base
    {

        [Required, MaxLength(50)]
        public string nameEn { get; set; }

        [MaxLength(50)]
        public string nameBn { get; set; }

        [MaxLength(500)]
        public string description { get; set; }
    }
}
