using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Degree", Schema = "HR")]
    public class Degree 
    {
        public int id { get; set; }

        [Required]
        public string degreeName { get; set; }
        public string degreeNameBn { get; set; }

        public string degreeShortName { get; set; }

        public int levelOfEducationId { get; set; }

        public LevelOfEducation levelOfEducation { get; set; }
    }
}
