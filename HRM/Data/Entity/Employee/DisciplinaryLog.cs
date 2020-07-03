using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Employee
{
    [Table("DisciplinaryLog", Schema = "HR")]
    public class DisciplinaryLog
    {
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        //public int? OffenseId { get; set; }
        //public DisciplineInvestigation.Offense offense { get; set; }

        //public int? naturalPunishmentId { get; set; }
        //public NaturalPunishment naturalPunishment { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? punishmentDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startingDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? endDate { get; set; }

        public string goNumberWithDate { get; set; }

        public string goFileURL { get; set; }

        public string remarks { get; set; }

    }
}
