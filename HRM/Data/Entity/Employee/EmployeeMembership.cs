using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeMembership", Schema = "HR")]
    public class EmployeeMembership 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public string nameOrganization { get; set; }
        public string membershipNo { get; set; }

        public int? membershipId { get; set; }
        public Membership membership { get; set; }

        public string remarks { get; set; }
    }
}
