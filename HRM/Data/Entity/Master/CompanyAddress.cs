using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Master
{
    public class CompanyAddress: Base
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

        [MaxLength(50)]
        public string union { get; set; }

        [MaxLength(50)]
        public string postOffice { get; set; }

        [MaxLength(50)]
        public string postCode { get; set; }

        [MaxLength(50)]
        public string blockSector { get; set; }

        [MaxLength(100)]
        public string houseVillage { get; set; }

        [MaxLength(20)]
        public string type { get; set; }  //Organization or Resourse
    }
}
