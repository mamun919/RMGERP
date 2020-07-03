using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Degree", Schema = "HR")]
    public class Degree 
    {
        [Required]
        public string degreeName { get; set; }
        public string degreeNameBn { get; set; }

        public string degreeShortName { get; set; }

        public int levelofeducationId { get; set; }

        public LevelofEducation levelofeducation { get; set; }
    }
}
