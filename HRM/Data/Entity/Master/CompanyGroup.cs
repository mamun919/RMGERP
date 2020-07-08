using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class CompanyGroup: Base
    {
        [MaxLength(50)]
        public string groupName { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }
    }
}
