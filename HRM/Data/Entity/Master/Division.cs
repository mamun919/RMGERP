using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class Division : Base
    {

        [Required, MaxLength(50)]
        public string divisionCode { get; set; }

        [Required, MaxLength(20)]
        public string divisionName { get; set; }

        [MaxLength(20)]
        public string divisionNameBn { get; set; }

        [MaxLength(20)]
        public string shortName { get; set; }

        public int countryId { get; set; }

        public Country country { get; set; }
    }
}
