using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("Spouse", Schema = "HR")]
    public class Spouse:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(50)]
        public string spouseName { get; set; }

        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(100)]
        public string spouseNameBn { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfBirth { get; set; }

        [MaxLength(50)]
        public string occupation { get; set; }

        [MaxLength(20)]
        public string gender { get; set; }

        [MaxLength(40)]
        public string designation { get; set; }

        [MaxLength(100)]
        public string organization { get; set; }

        [MaxLength(100)]
        public string bin { get; set; }

        [MaxLength(50)]
        public string nid { get; set; }

        [MaxLength(10)]
        public string bloodGroup { get; set; }

        [MaxLength(30)]
        public string contact { get; set; }

        [MaxLength(50)]
        public string highestEducation { get; set; }

        [MaxLength(50)]
        public string homeDistrict { get; set; }

    }
}
