using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("OtherQualificationHead", Schema = "HR")]
    public class OtherQualificationHead
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
