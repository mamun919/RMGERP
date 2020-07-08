using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeProjectActivity", Schema = "HR")]
    public class EmployeeProjectActivity:Base
    {
        public int? employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }


        //public int? hRDonerId { get; set; }
        //public HrDoner hRDoner { get; set; }

        //public int? hRActivityId { get; set; }
        //public HrActivity hRActivity { get; set; }

        public int? isActive { get; set; }
    }
}
