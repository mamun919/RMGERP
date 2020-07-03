using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("HRProject", Schema = "HR")]
    public class HRProject
    {
        public string name { get; set; }

        public string code { get; set; }
    }
}
