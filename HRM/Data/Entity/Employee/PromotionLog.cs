using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("PromotionLog", Schema = "HR")]
    public class PromotionLog 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public string designation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }

        public int? payScaleId { get; set; }
        public SalaryGrade payScale { get; set; }

        public string goNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? goDate { get; set; }

        public string remark { get; set; }
    }
}
