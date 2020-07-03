using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Cadre", Schema = "HR")]
    public class Cadre
    {
        [Required]
        public string cadreName { get; set; }
        public string cadreNameBn { get; set; }

        public string cadreShortName { get; set; }
    }
}
