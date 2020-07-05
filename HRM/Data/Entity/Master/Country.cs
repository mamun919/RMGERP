using System.ComponentModel.DataAnnotations;

namespace HRM.Data.Entity.Master
{
    public class Country 
    {
        public int id { get; set; }

        [Required]
        public string countryCode { get; set; }

        [Required]
        public string countryName { get; set; }
        public string countryNameBn { get; set; }

        
        public string shortName { get; set; }

    }
}
