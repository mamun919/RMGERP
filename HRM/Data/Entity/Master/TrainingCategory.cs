using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("TrainingCategory", Schema = "HR")]
    public class TrainingCategory: Base
    {

        [Required, MaxLength(100)]
        public string trainingCategoryName { get; set; }

        [MaxLength(100)]
        public string trainingCategoryNameBn { get; set; }

        [MaxLength(50)]
        public string trainingCategoryShortName { get; set; }
    }
}
