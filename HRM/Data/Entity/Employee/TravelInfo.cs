using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;


namespace HRM.Data.Entity.Employee
{
    [Table("TravelInfo", Schema = "HR")]
    public class TravelInfo : Base
    {
        public int employeeId { get; set; }  //Fk
        public EmployeeInfo employee { get; set; }

        public int? travelPurposeId { get; set; }
        public TravelPurpose travelPurpose { get; set; }

        [MaxLength(100)]
        public string purpose { get; set; }

        [MaxLength(100)]
        public string location { get; set; }

        public int? countryId { get; set; }
        public Country country { get; set; }

        [MaxLength(100)]
        public string sponsoringAgency { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? endDate { get; set; }

        [MaxLength(100)]
        public string goNumber { get; set; }

        [MaxLength(100)]
        public string goDate { get; set; }

        [MaxLength(100)]
        public string file { get; set; }

        [MaxLength(100)]
        public string titleOfFile { get; set; }

    }
}
