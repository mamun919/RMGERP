namespace HRM.Data.Entity.Master
{
    public class CompanyGroup
    {
        public int id { get; set; }

        public string groupName { get; set; }

        public int? companyId { get; set; }
        public Company company { get; set; }
    }
}
