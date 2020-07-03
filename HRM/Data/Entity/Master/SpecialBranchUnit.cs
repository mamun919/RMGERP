
using HRM.Data.Entity.Master;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("SpecialBranchUnit", Schema = "HR")]
    public class SpecialBranchUnit
    {
        public string branchUnitName { get; set; }

        public string branchUnitNameBN { get; set; }

        public string branchCode { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }

        public int? shortOrder { get; set; }
    }
}
