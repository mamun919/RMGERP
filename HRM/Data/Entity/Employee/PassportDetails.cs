using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("PassportDetails", Schema = "HR")]
    public class PassportDetails : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string passportNumber { get; set; }

        [MaxLength(100)]
        public string placeOfIssue { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfIssue { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfExpair { get; set; }
    }
}
