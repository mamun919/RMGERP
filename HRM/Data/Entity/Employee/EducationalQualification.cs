using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EducationalQualification", Schema = "HR")]
    public class EducationalQualification : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string institution { get; set; }

        public int? resultId { get; set; }
        public Result result { get; set; }

        [MaxLength(100)]
        public string majorGroup { get; set; }

        [MaxLength(100)]
        public string grade { get; set; }

        public int? passingYear { get; set; }

        public int? degreeId { get; set; }
        public Degree degree { get; set; }
        
        public int? relDegreeSubjectId { get; set; }
        public RelDegreeSubject relDegreeSubject { get; set; }

    }
}
