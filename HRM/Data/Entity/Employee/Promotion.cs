using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    
    [Table("Promotion", Schema = "HR")]
    public class Promotion:Base 
    {
        public int employeeId { get; set; }  //Fk

        public EmployeeInfo employeeInfo { get; set; }

        [MaxLength(100)]
        public string promotionType { get; set; }

        public int? designationId { get; set; }
        public Designation designation { get; set; }

        [MaxLength(20)]
        public string promotionDate { get; set; }

        public int? salaryGradeId { get; set; }
        public SalaryGrade salaryGrade { get; set; }

        public decimal? basic { get; set; }
    }
}
