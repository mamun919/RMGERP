using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("OtherActivity", Schema = "HR")]
    public class OtherActivity
    {
        public int employeeID { get; set; }
        public EmployeeInfo employee { get; set; }

        public int? activityNameId { get; set; }
        public ActivityName activityName { get; set; }

        public string name { get; set; }

        public string description { get; set; }
    }
}
