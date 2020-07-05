
using HRM.Data.Entity.Master;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("BranchUnit", Schema = "HR")]
    public class BranchUnit
    {
        public string branchUnitName { get; set; }

        public string branchUnitNameBn { get; set; }

        public string branchCode { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }

        public int? shortOrder { get; set; }
    }
}
