using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Children", Schema = "HR")]
    public class Children :Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [StringLength(100)]
        public string childName { get; set; }

        [StringLength(100)]
        public string childNameBn { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfBirth { get; set; }
        
        [MaxLength(100)]
        public string education { get; set; }

        [MaxLength(50)]
        public string gender { get; set; }

        [MaxLength(100)]
        public string bin { get; set; }

        [MaxLength(100)]
        public string occupation { get; set; }

        [MaxLength(100)]
        public string designation { get; set; }

        [MaxLength(200)]
        public string organization { get; set; }

        [MaxLength(100)]
        public string nid { get; set; }

        [MaxLength(50)]
        public string bloodGroup { get; set; }

        public int disability { get; set; }
    }
}
