using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Master
{
    public class AddressType
    {
        public int id { get; set; }

        [Required]
        public string typeName { get; set; }
    }
}
