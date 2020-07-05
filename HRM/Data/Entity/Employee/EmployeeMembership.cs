using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeMembership", Schema = "HR")]
    public class EmployeeMembership 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public string nameOfOrganization { get; set; }
        public string membershipNo { get; set; }

        public int? membershipId { get; set; }
        public Membership membership { get; set; }

        public string remarks { get; set; }
    }
}
