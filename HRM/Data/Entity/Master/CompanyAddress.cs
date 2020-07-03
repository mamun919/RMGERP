using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Master
{
    public class CompanyAddress
    {
        public int? addressTypeId { get; set; }
        public AddressType addressType { get; set; }

        public int? countryId { get; set; }
        public Country country { get; set; }

        public int? divisionId { get; set; }
        public Division division { get; set; }

        public int? districtId { get; set; }
        public District district { get; set; }

        public int? thanaId { get; set; }
        public Thana thana { get; set; }

        public string union { get; set; }

        public string postOffice { get; set; }

        public string postCode { get; set; }

        public string blockSector { get; set; }

        public string houseVillage { get; set; }

        public string type { get; set; }  //Organization or Resourse
    }
}
