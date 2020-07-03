using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Award", Schema = "HR")]
    public class Award
    {
        [Required]
        public string awardName { get; set; }
        public string awardNameBn { get; set; }

        public string awardShortName { get; set; }
    }
}
