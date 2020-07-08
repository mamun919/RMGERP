using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("TravelPurpose", Schema = "HR")]
    public class TravelPurpose: Base
    {

        [Required, MaxLength(100)]
        public string purposeName { get; set; }
        [MaxLength(100)]
        public string purposeNameBn { get; set; }

        [MaxLength(100)]
        public string purposeShortName { get; set; }
    }
}
