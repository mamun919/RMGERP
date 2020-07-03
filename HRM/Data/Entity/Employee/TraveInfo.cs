using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;


namespace HRM.Data.Entity.Employee
{
    [Table("TraveInfo", Schema = "HR")]
    public class TraveInfo 
    {
        //Foreign Relation
        public int employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

        public int? travelPurposeId { get; set; }
        public TravelPurpose travelPurpose { get; set; }

        public string purpose { get; set; }

        public string location { get; set; }

        public int? countryId { get; set; }
        public Country country { get; set; }

        public string sponsoringAgency { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? endDate { get; set; }

        public string goNumber { get; set; }

        public string goDate { get; set; }

        public string file { get; set; }

        public string titleOfFile { get; set; }

        public string remarks { get; set; }

    }
}
