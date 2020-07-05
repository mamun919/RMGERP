using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("TravelPurpose", Schema = "HR")]
    public class TravelPurpose
    {
        public int id { get; set; }

        [Required]
        public string purposeName { get; set; }
        public string purposeNameBn { get; set; }

        public string purposeShortName { get; set; }
    }
}
