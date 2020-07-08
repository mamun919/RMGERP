using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("OtherQualificationHead", Schema = "HR")]
    public class OtherQualificationHead: Base
    {
        [MaxLength(50)]
        public string name { get; set; }
    }
}
