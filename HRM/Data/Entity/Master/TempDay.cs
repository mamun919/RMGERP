using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("TempDay", Schema = "HR")]
    public class TempDay 
    {        
        public string daysInBetween { get; set; }
    }
}
