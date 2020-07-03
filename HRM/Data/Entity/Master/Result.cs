using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Result", Schema = "HR")]
    public class Result 
    {
        [Required]
        public string resultName { get; set; }
        public string resultNameBn { get; set; }
        
        public string resultShortName { get; set; }
        [Required]
        public decimal resultMaxValue { get; set; }
    }
}
