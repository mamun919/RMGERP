using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Year", Schema = "HR")]
    public class Year : Base
    {
        [MaxLength(20)]
        public string year { get; set; }
    }
}
