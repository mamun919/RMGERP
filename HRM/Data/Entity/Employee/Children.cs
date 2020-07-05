using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Children", Schema = "HR")]
    public class Children 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string childName { get; set; }

        public string childNameBn { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfBirth { get; set; }
        
        public string education { get; set; }
        
        public string gender { get; set; }
        
        public string bin { get; set; }

        public string occupation { get; set; }
        
        public string designation { get; set; }
        
        public string organization { get; set; }

        [MaxLength(100)]
        public string nid { get; set; }

        public string bloodGroup { get; set; }

        public int disability { get; set; }
    }
}
