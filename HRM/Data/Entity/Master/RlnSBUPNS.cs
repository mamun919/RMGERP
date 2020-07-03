using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("RlnSBUPNS", Schema = "HR")]
    public class RlnSBUPNS
    {
        public int? pNSId { get; set; }
        public PNS pNS { get; set; }

        public int? specialBranchUnitId { get; set; }
        public SpecialBranchUnit specialBranchUnit { get; set; }
    }
}
