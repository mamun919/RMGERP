using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Subject", Schema = "HR")]
    public class Subject
    {
        [Required]
        public string subjectName { get; set; }
        public string subjectNameBn { get; set; }

        public string subjectShortName { get; set; }
    }
}
