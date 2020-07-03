using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Occupation", Schema = "HR")]
    public class Occupation
    {
        [Required]
        public string occupationName { get; set; }
        public string occupationNameBn { get; set; }

        public string occupationShortName { get; set; }
    }
}
