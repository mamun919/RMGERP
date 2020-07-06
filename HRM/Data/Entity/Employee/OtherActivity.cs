using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("OtherActivity", Schema = "HR")]
    public class OtherActivity:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string activityName { get; set; }
        
        [MaxLength(100)]
        public string description { get; set; }
    }
}
