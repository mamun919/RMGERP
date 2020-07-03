using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("LevelofEducation", Schema = "HR")]
    public class LevelofEducation
    {
        [Required]
        public string levelofeducationName { get; set; }
        public string levelofeducationNameBn { get; set; }
    }
}
