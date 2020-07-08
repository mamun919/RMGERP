using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("TrainingInstitute", Schema = "HR")]
    public class TrainingInstitute: Base
    {
        [Required, MaxLength(100)]
        public string trainingInstituteName { get; set; }

        [MaxLength(100)]
        public string trainingInstituteNameBn { get; set; }

        [MaxLength(50)]
        public string trainingInstituteShortName { get; set; }
    }
}
