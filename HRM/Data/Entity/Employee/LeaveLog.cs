using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("LeaveLog", Schema = "HR")]
    public class LeaveLog 
    {
        public int id { get; set; }
        
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? leaveTypeId { get; set; }
        public LeaveType leaveType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? leaveFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? leaveTo { get; set; }

        public string purposeOfLeave { get; set; }
        public string status { get; set; }
    }
}
