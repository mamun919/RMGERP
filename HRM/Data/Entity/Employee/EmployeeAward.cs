using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeAward", Schema = "HR")]
    public class EmployeeAward : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string awardName { get; set; }

        [MaxLength(100)]
        public string purpose { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? awardDate { get; set; }

        [MaxLength(100)]
        public string issuedBy { get; set; }
    }
}
