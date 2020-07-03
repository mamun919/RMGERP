using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("QualificationHead", Schema = "HR")]
    public class QualificationHead
    {
        public string name { get; set; }
    }
}
