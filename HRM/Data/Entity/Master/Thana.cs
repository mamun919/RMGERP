using System.ComponentModel.DataAnnotations;

namespace HRM.Data.Entity.Master
{
    public class Thana 
    {
       
        public string thanaCode { get; set; }
      
        public string thanaName { get; set; }

        public string shortName { get; set; }
        public string thanaNameBn { get; set; }

        public int districtId { get; set; }

        public District district { get; set; }
    }
}
