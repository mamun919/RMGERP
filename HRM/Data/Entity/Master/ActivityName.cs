using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("ActivityName", Schema = "HR")]
    public class ActivityName
    {
        public int activityTypeId { get; set; }
        public HRPMSActivityType activityType { get; set; }

        public string name { get; set; }
    }
}
