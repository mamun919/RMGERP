using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("NomineeDetail", Schema = "HR")]
    public class NomineeDetail
    {
        public int id { get; set; }

        public int? nomineeId { get; set; }
        public Nominee nominee { get; set; }

        public decimal? percentage { get; set; }
    }
}
