using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("PNS", Schema = "HR")]
    public class PNS
    {
        public string code { get; set; }

        public string name { get; set; }
    }
}
