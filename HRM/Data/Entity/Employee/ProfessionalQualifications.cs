using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("ProfessionalQualifications", Schema = "HR")]
    public class ProfessionalQualifications:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? qualificationHeadId { get; set; }
        public QualificationHead qualificationHead { get; set; }

        [MaxLength(100)]
        public string subject { get; set; }

        public int? resultId { get; set; }
        public Result result { get; set; }

        [MaxLength(100)]
        public string instituteName { get; set; }

        [MaxLength(20)]
        public string passingYear { get; set; }

        [MaxLength(50)]
        public string markGrade { get; set; }
    }
}
