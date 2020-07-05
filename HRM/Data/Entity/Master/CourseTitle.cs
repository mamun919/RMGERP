using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("CourseTitle", Schema = "HR")]
    public class CourseTitle 
    {
        public string nameEn { get; set; }

        public string nameBn { get; set; }

        public string remarks { get; set; }
    }
}
