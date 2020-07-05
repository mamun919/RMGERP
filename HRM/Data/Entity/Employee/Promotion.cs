using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    
    [Table("Promotion", Schema = "HR")]
    public class Promotion
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk

        public EmployeeInfo employeeInfo { get; set; }

        public string promotionType { get; set; }

        public int? designationId { get; set; }
        public Designation designation { get; set; }

        public string promotionDate { get; set; }

        public int? salaryGradeId { get; set; }
        public SalaryGrade salaryGrade { get; set; }

        public decimal? basic { get; set; }

        public string remarks { get; set; }
    }
}
