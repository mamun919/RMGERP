using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Subject", Schema = "HR")]
    public class Subject:Base
    {
        
        [Required, MaxLength(50)]
        public string subjectName { get; set; }

        [MaxLength(50)]
        public string subjectNameBn { get; set; }

        [MaxLength(50)]
        public string subjectShortName { get; set; }
    }
}
