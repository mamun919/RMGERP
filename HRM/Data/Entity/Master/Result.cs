using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Result", Schema = "HR")]
    public class Result :Base
    {
        
        [Required, MaxLength(50)]
        public string resultName { get; set; }

        [MaxLength(50)]
        public string resultNameBn { get; set; }

        [MaxLength(50)]
        public string resultShortName { get; set; }

        [Required]
        public decimal resultMaxValue { get; set; }
    }
}
