using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("CourseTitle", Schema = "HR")]
    public class CourseTitle : Base
    {
        [MaxLength(50)]
        public string nameEn { get; set; }

        [MaxLength(50)] 
        public string nameBn { get; set; }
    }
}
