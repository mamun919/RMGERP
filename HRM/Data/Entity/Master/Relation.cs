using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Relation", Schema = "HR")]
    public class Relation: Base
    {

        [Required, MaxLength(30)]
        public string relationName { get; set; }

        [MaxLength(30)]
        public string relationNameBn { get; set; }

        [MaxLength(30)]

        public string relationShortName { get; set; }
    }
}
