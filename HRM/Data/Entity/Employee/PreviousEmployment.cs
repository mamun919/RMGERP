using System;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("PreviousEmployment", Schema = "HR")]
    public class PreviousEmployment
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }


        public string companyName { get; set; }

        public string position { get; set; }

        public string department { get; set; }

        public string companyBusiness { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }

        public string companyLocation { get; set; }

        public string responsibilities { get; set; }
    }
}
