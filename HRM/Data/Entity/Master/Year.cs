using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Year", Schema = "HR")]
    public class Year 
    {
        public string year { get; set; }

        public string remarks { get; set; }
    }
}
