using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("LevelOfEducation", Schema = "HR")]
    public class LevelOfEducation:Base
    {
        [Required, MaxLength(50)]
        public string levelOfEducationName { get; set; }
        
        [MaxLength(30)]
        public string levelOfEducationNameBn { get; set; }
    }
}
