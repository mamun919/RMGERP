using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("ShiftGroupDetail", Schema = "HR")]
    public class ShiftGroupDetail 
    {
        public int id { get; set; }

        [Required]
        public string weekDay { get; set; }
        [Required]
        public string startTime { get; set; }
        [Required]
        public string endTime { get; set; }
        
        public bool holiday { get; set; }

        public int shiftGroupMasterId { get; set; }

        public ShiftGroupMaster shiftGroupMaster { get; set; }
    }
}
