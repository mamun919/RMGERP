using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("NomineeFund", Schema = "HR")]
    public class NomineeFund
    {
        public string name { get; set; }
    }
}
