using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Holiday", Schema = "HR")]
    public class Holiday 
    {
        public int id { get; set; }

        [Required]
        public string weeklyHoliday { get; set; }
        [Required]
        public string holidayName { get; set; }
        public string holidayNameBn { get; set; }
        [Required]
        public int year { get; set; }
    }
}
