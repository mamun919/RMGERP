using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("ServiceStatus", Schema = "HR")]
    public class ServiceStatus
    {
        [Required]
        public string statusName { get; set; }
        public string statusNameBn { get; set; }

        public string statusShortName { get; set; }
    }
}
