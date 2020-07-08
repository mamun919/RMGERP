using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Vehicle", Schema = "HR")]
    public class Vehicle:Base
    {
        [Required, MaxLength(50)]
        public string vehicleType { get; set; }

        [MaxLength(60)]
        public string vehicleTypeBn { get; set; }

        [MaxLength(50)]
        public string vehicleShortName { get; set; }
    }
}
