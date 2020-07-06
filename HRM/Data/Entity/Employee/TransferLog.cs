using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("TransferLog", Schema = "HR")]
    public class TransferLog : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string workStation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? from { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? to { get; set; }

        public int? designationId { get; set; }
        public Designation designation { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }

        public int? salaryGradeId { get; set; }
        public SalaryGrade salaryGrade { get; set; }
    }
}
