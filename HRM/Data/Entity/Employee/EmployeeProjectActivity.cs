using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeProjectActivity", Schema = "HR")]
    public class EmployeeProjectActivity
    {
        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public int? hRProjectId { get; set; }
        public HRProject hRProject { get; set; }

        public int? hRDonerId { get; set; }
        public HRDoner hRDoner { get; set; }

        public int? hRActivityId { get; set; }
        public HRActivity hRActivity { get; set; }

        public int? isActive { get; set; }
    }
}
