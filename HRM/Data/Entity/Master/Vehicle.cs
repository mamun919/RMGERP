using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Vehicle", Schema = "HR")]
    public class Vehicle
    {
        public int id { get; set; }
        
        [Required]
        public string vehicleType { get; set; }
        public string vehicleTypeBn { get; set; }

        public string vehicleShortName { get; set; }
    }
}
