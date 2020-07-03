using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Membership", Schema = "HR")]
    public class Membership
    {
        [Required]
        public string membershipName { get; set; }
        public string membershipNameBn { get; set; }

        public string membershipShortName { get; set; }
    }
}
