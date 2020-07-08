using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Religion", Schema = "HR")]
    public class Religion:Base
    {

        [Required, MaxLength(20)]
        public string name { get; set; }

        [MaxLength(20)]
        public string nameBn { get; set; }

        [MaxLength(20)]
        public string shortName { get; set; }
    }
}
