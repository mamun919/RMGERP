using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("ShiftGroupMaster", Schema = "HR")]
    public class ShiftGroupMaster : Base
    {

        [Required, MaxLength(50)]
        public string shiftName { get; set; }

        [MaxLength(50)]
        public string shiftNameBn { get; set; }
    }
}
