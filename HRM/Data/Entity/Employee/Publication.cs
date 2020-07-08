using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Publication", Schema = "HR")]
    public class Publication : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string publicationName { get; set; }

        [MaxLength(50)]
        public string publicationType { get; set; }

        [MaxLength(100)]
        public string publicationPlace { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? publicationDate { get; set; }
    }
}
