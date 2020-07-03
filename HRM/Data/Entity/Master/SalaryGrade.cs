using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("SalaryGrade", Schema = "Payroll")]
    public class SalaryGrade
    {
        [MaxLength(100)]
        public string gradeName { get; set; }

        
        public decimal basicAmount { get; set; }

        [MaxLength(100)]
        public string payScale { get; set; }

        [Required]
        public decimal currentBasic { get; set; }
    }
}
