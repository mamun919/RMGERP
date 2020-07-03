using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("BookCategory", Schema = "HR")]
    public class BookCategory
    {
        [Required]
        public string bookCategoey { get; set; }
        public string bookCategoeyBn { get; set; }

        public string bookCategoryShortName { get; set; }
    }
}
