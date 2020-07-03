using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("ShiftGroupMaster", Schema = "HR")]
    public class ShiftGroupMaster 
    {
        [Required]
        public string shiftName { get; set; }
        public string shiftNameBn { get; set; }
    }
}
