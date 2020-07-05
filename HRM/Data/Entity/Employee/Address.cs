using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("Address", Schema = "HR")]
    public class Address 
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

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

        public string roadNumber { get; set; }
        //Type: Permamnent or Present
        [Required]
        public string type { get; set; } 
    }
}
