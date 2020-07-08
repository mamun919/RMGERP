using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("Address", Schema = "HR")]
    public class Address : Base
    {

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

        [StringLength(100)]
        public string union { get; set; }

        [StringLength(100)]
        public string postOffice { get; set; }

        [StringLength(50)]
        public string postCode { get; set; }

        [StringLength(100)]
        public string blockSector { get; set; }

        [StringLength(200)]
        public string houseVillage { get; set; }

        [StringLength(100)]
        public string roadNumber { get; set; }

        //Type: Permamnent or Present
        [Required, StringLength(100)]
        public string type { get; set; } 
    }
}
