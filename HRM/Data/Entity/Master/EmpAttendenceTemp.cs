using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("EmpAttendenceTemp", Schema = "HR")]
    public class EmpAttendenceTemp 
    {
        
        public string cardNo { get; set; }

        public string currentDateTime { get; set; }

        public string time { get; set; }

        public string date { get; set; }

        public string timeOut { get; set; }
    }
}
