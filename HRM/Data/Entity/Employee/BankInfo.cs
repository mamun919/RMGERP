using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("BankInfo", Schema = "HR")]
    public class BankInfo : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [StringLength(100)]
        public string bankName { get; set; }

        [StringLength(100)]
        public string branchName { get; set; }

        [StringLength(100)]
        public string accountNumber { get; set; }

        [StringLength(200)]
        public string ibus { get; set; }
    }
}