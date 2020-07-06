using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("OtherQualification", Schema = "HR")]
    public class OtherQualification:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? otherQualificationHeadId { get; set; }
        public OtherQualificationHead otherQualificationHead { get; set; }

        [MaxLength(50)]
        public string subject { get; set; }

        public int? resultId { get; set; }
        public Result result { get; set; }

        [MaxLength(100)]
        public string instituteName { get; set; }

        [MaxLength(20)]
        public string passingYear { get; set; }

        [MaxLength(30)]
        public string markGrade { get; set; }
    }
}
