using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("LevelOfEducation", Schema = "HR")]
    public class LevelOfEducation
    {
        public int id { get; set; }

        [Required]
        public string levelOfEducationName { get; set; }
        public string levelOfEducationNameBn { get; set; }
    }
}
