using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("TransferLog", Schema = "HR")]
    public class TransferLog 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public string workStation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? from { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? to { get; set; }

        public string designation { get; set; }
        
        public int? designatioId { get; set; }
        public Designation designatio { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }

        public int? salaryGradeId { get; set; }
        public SalaryGrade salaryGrade { get; set; }
    }
}
