using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("ProfessionalQualifications", Schema = "HR")]
    public class ProfessionalQualifications
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? qualificationHeadId { get; set; }
        public QualificationHead qualificationHead { get; set; }

        public string subject { get; set; }

        public int? resultId { get; set; }
        public Result result { get; set; }

        public string instituteName { get; set; }

        public string passingYear { get; set; }

        public string markGrade { get; set; }
    }
}
