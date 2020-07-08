
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("AcrInfo", Schema = "HR")]
    public class AcrInfo : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string startDate { get; set; }
        public string endDate { get; set; }

        [MaxLength(250)]
        public string supervisorName { get; set; }

        [MaxLength(100)]
        public string supervisorDesg { get; set; }

        [MaxLength(250)]
        public string signatoryName { get; set; }

        [MaxLength(100)]
        public string signatoryDesg { get; set; }

        [MaxLength(10)]
        public string year { get; set; }

        public string advanceComment { get; set; }

        public int score { get; set; } //ConfidentialField
        }
}
