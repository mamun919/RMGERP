using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("HRDoner", Schema = "HR")]
    public class HRDoner
    {
        public string name { get; set; }

        public string contactNumber { get; set; }

        public string Address { get; set; }

        public string code { get; set; }
    }
}
