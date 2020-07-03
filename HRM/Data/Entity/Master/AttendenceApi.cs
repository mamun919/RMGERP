using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("AttendenceApi", Schema = "HR")]
    public class AttendenceApi 
    {
        
        public string empCode { get; set; }

        public string entryDate { get; set; }

        public int status { get; set; }
    }
}
