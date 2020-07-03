using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Language", Schema = "HR")]
    public class Language
    {
        [Required]
        public string languageName { get; set; }
        public string languageNameBn { get; set; }

        public string languageShortName { get; set; }
    }
}
