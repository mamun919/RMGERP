using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("HRActivity", Schema = "HR")]
    public class HRActivity 
    {
        public string name { get; set; }

        public string code { get; set; }
    }
}
