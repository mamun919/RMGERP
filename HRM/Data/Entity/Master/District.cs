using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class District : Base
    {
        [Required, MaxLength(30)]
        public string districtCode { get; set; }

        [Required, MaxLength(30)]
        public string districtName { get; set; }
        
        [MaxLength(30)]
        public string districtNameBn { get; set; }

        [MaxLength(30)]
        public string shortName { get; set; }

        public int divisionId { get; set; }

        public Division division { get; set; }
    }
}
