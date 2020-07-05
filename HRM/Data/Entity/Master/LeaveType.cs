using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("LeaveType", Schema = "HR")]
    public class LeaveType 
    {
        public int id { get; set; }

        [Required]
        public string nameEn { get; set; }
        public string nameBn { get; set; }
        public string description { get; set; }
    }
}
