using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("ShiftGroupDetail", Schema = "HR")]
    public class ShiftGroupDetail : Base
    {
      [Required, MaxLength(20)]
        public string weekDay { get; set; }

        [Required, MaxLength(30)]
        public string startTime { get; set; }

        [Required, MaxLength(30)]
        public string endTime { get; set; }
        
        public bool holiday { get; set; }

        public int shiftGroupMasterId { get; set; }

        public ShiftGroupMaster shiftGroupMaster { get; set; }
    }
}
