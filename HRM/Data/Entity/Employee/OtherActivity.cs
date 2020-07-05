using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("OtherActivity", Schema = "HR")]
    public class OtherActivity
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string activityName { get; set; }

        public string name { get; set; }

        public string description { get; set; }
    }
}
