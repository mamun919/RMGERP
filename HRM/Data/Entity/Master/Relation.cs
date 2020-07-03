using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Relation", Schema = "HR")]
    public class Relation
    {
        [Required]
        public string relationName { get; set; }
        public string relationNameBn { get; set; }

        public string relationShortName { get; set; }
    }
}
