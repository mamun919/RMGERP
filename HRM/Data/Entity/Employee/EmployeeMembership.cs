using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeMembership", Schema = "HR")]
    public class EmployeeMembership : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string nameOfOrganization { get; set; }

        [MaxLength(100)]
        public string membershipNo { get; set; }

        public int? membershipId { get; set; }
        public Membership membership { get; set; }
    }
}
