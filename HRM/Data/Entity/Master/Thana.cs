using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class Thana : Base
    {
       [MaxLength(50)]
        public string thanaCode { get; set; }

        [MaxLength(50)]
        public string thanaName { get; set; }

        [MaxLength(50)]
        public string shortName { get; set; }

        [MaxLength(50)]
        public string thanaNameBn { get; set; }

        public int districtId { get; set; }

        public District district { get; set; }
    }
}
