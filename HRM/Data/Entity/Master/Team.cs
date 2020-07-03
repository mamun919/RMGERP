using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    public class Team 
    {
        public int? teamId { get; set; }
        public Team team { get; set; }

        [StringLength(50)]
        public string teamCode { get; set; }

        [StringLength(250)]
        public string memberName { get; set; }

        //public int? moduleId { get; set; }
        //public ERPModule module { get; set; }

        //public string aspnetuserId { get; set; }
        //[ForeignKey("aspnetuserId")]
        //public virtual ApplicationUser aspnetuser { get; set; }

        public int? isActive { get; set; }
    }
}
