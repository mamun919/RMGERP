
namespace HRM.Data.Entity.Master
{
    public class ERPModuleAssign
    {
        public int? companyId { get; set; }
        public Company company { get; set; }

        public string roleId { get; set; }
    }
}
