using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    [Table("ItemSpecification", Schema = "SCM")]
    public class ItemSpecification 
    {
        public int id { get; set; }
        //public Item Item { get; set; }

        [MaxLength(250)]
        public string specificationName { get; set; }
    }
}
