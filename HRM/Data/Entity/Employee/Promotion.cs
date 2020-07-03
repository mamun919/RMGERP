using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    /*
        status: Not used by apllication
        Verified By:  Jaggesher
        Date: 23/04/2019
    */
    [Table("Promotion", Schema = "HR")]
    public class Promotion
    {
        public int employeeId { get; set; }

        public EmployeeInfo employeeInfo { get; set; }

        public string promotionType { get; set; }

        public int? designationId { get; set; }
        public Designation designation { get; set; }

        public string promotionDate { get; set; }

        public int? salaryGradeId { get; set; }
        public SalaryGrade salaryGrade { get; set; }

        public decimal? Basic { get; set; }

        public string Remarks { get; set; }
    }
}
