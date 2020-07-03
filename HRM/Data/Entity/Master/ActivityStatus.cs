using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("ActivityStatus", Schema = "HR")]
    public class ActivityStatus
    {
        [Required]
        public string statusName { get; set; }
        public string statusNameBn { get; set; }

        public string shortName { get; set; }
    }
}
