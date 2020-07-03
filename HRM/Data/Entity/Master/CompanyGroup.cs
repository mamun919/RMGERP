namespace HRM.Data.Entity.Master
{
    public class CompanyGroup
    {
        public string groupName { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }
    }
}
