using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("HRPMSActivityType", Schema = "HR")]
    public class HRPMSActivityType
    {
        public string name { get; set; }
    }
}
