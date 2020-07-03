using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("BankInfo", Schema = "HR")]
    public class BankInfo 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public string bankName { get; set; }

        public string branchName { get; set; }

        public string accountNumber { get; set; }

        public string ibus { get; set; }
    }
}