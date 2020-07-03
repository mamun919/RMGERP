using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("QualificationAndValidation", Schema = "HR")]
    public class QualificationAndValidation
    {
        public int employeeID { get; set; }
        public EmployeeInfo employee { get; set; }

        public int? qualificationHeadId { get; set; }
        public QualificationHead qualificationHead { get; set; }

        public string attachment { get; set; }

        public int? isValid { get; set; }
    }
}
