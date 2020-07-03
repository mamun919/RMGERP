using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Organization", Schema = "HR")]
    public class Organization 
    {
        [Required]
        public string organizationName { get; set; }
        public string organizationNameBn { get; set; }

        [Required]
        public string organizationType { get; set; }
    }
}
