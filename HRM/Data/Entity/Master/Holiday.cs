using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Holiday", Schema = "HR")]
    public class Holiday : Base 
    {
        [Required,MaxLength(30)]
        public string weeklyHoliday { get; set; }

        [Required, MaxLength(30)]
        public string holidayName { get; set; }

        [MaxLength(30)]
        public string holidayNameBn { get; set; }
        [Required]
        public int year { get; set; }
    }
}
