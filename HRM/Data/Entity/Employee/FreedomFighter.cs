using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("FreedomFighter", Schema = "HR")]
    public class FreedomFighter: Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string number { get; set; }

        [MaxLength(100)]
        public string owner { get; set; }

        [MaxLength(100)]
        public string relationship { get; set; }

        [MaxLength(50)]
        public string sectorNo { get; set; }

    }
}
