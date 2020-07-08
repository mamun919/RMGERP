
using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Master;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("BranchUnit", Schema = "HR")]
    public class BranchUnit: Base
    {
        [MaxLength(100)]
        public string branchUnitName { get; set; }

        [MaxLength(100)]
        public string branchUnitNameBn { get; set; }

        [MaxLength(100)]
        public string branchCode { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }

        public int? shortOrder { get; set; }
    }
}
