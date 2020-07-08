using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class AddressType: Base
    { 
        [Required, MaxLength(50)]
        public string typeName { get; set; }
    }
}
