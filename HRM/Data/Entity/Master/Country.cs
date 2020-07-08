using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class Country : Base
    {
        [Required, MaxLength(50)]
        public string countryCode { get; set; }

        [Required, MaxLength(50)]
        public string countryName { get; set; }

        [MaxLength(50)]
        public string countryNameBn { get; set; }

        [MaxLength(50)]
        public string shortName { get; set; }
    }
}
