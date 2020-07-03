using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("MunicipilityLocation", Schema = "HR")]
    public class MunicipilityLocation
    {
        [Required]
        public string locationName { get; set; }
        public string locationNameBn { get; set; }

        public string shortName { get; set; }
    }
}
