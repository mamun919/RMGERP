using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    [Table("Language", Schema = "HR")]
    public class Language: Base 
    {

        [Required, MaxLength(30)]
        public string languageName { get; set; }

        [MaxLength(30)]
        public string languageNameBn { get; set; }

        [MaxLength(30)]
        public string languageShortName { get; set; }
    }
}
