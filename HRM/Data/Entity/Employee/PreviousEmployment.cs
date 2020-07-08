using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("PreviousEmployment", Schema = "HR")]
    public class PreviousEmployment:Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        [MaxLength(100)]
        public string companyName { get; set; }

        [MaxLength(50)]
        public string position { get; set; }

        [MaxLength(50)]
        public string department { get; set; }

        [MaxLength(100)]
        public string companyBusiness { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }

        [MaxLength(100)]
        public string companyLocation { get; set; }

        [MaxLength(300)]
        public string responsibilities { get; set; }
    }
}
