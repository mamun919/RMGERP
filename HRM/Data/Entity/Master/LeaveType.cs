using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("LeaveType", Schema = "HR")]
    public class LeaveType 
    {
        [Required]
        public string nameEn { get; set; }
        public string nameBn { get; set; }
        public string description { get; set; }
    }
}
