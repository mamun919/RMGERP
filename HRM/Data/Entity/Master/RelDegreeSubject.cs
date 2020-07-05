using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("RelDegreeSubject", Schema = "HR")]
    public class RelDegreeSubject
    {
        public int id { get; set; }

        public int degreeId { get; set; }

        public Degree degree { get; set; }

        public int subjectId { get; set; }

        public Subject subject { get; set; }
    }
}
