using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("TrainingCategory", Schema = "HR")]
    public class TrainingCategory
    {
        public int id { get; set; }

        [Required]
        public string trainingCategoryName { get; set; }
        public string trainingCategoryNameBn { get; set; }

        public string trainingCategoryShortName { get; set; }
    }
}
