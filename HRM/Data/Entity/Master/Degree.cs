using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Degree", Schema = "HR")]
    public class Degree : Base
    {
        [Required, MaxLength(30)]
        public string degreeName { get; set; }

        [MaxLength(30)]
        public string degreeNameBn { get; set; }

        [MaxLength(30)]
        public string degreeShortName { get; set; }

        public int levelOfEducationId { get; set; }

        public LevelOfEducation levelOfEducation { get; set; }
    }
}
