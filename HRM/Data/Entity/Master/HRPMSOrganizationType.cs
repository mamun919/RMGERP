using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("HRPMSOrganizationType", Schema = "HR")]
    public class HRPMSOrganizationType
    {
        public string name { get; set; }
    }
}
