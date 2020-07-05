using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("OtherQualification", Schema = "HR")]
    public class OtherQualification
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? otherQualificationHeadId { get; set; }
        public OtherQualificationHead otherQualificationHead { get; set; }

        public string subject { get; set; }

        public int? resultId { get; set; }
        public Result result { get; set; }

        public string instituteName { get; set; }

        public string passingYear { get; set; }

        public string markGrade { get; set; }
    }
}
