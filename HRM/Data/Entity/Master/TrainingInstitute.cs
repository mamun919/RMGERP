using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("TrainingInstitute", Schema = "HR")]
    public class TrainingInstitute
    {
        [Required]
        public string trainingInstituteName { get; set; }
        public string trainingInstituteNameBn { get; set; }

        public string trainingInstituteShortName { get; set; }
    }
}
