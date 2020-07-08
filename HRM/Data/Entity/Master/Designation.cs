using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Designation", Schema = "HR")]
    public class Designation: Base
    {
        [Required, MaxLength(50)]
        public string designationCode { get; set; }

        [Required,MaxLength(50)]
        public string designationName { get; set; }

        [MaxLength(50)]
        public string designationNameBn { get; set; }

        [MaxLength(50)]
        public string shortName { get; set; }

        //public int? empType { get; set; }
    }
}
