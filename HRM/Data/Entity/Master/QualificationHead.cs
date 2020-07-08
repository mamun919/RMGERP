using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("QualificationHead", Schema = "HR")]
    public class QualificationHead :Base
    {
        [MaxLength(50)]
        public string name { get; set; }
    }
}
