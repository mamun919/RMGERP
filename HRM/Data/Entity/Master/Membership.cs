using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Membership", Schema = "HR")]
    public class Membership:Base
    {

        [Required, MaxLength(50)]
        public string membershipName { get; set; }

        [MaxLength(30)]
        public string membershipNameBn { get; set; }

        [MaxLength(30)]
        public string membershipShortName { get; set; }
    }
}
