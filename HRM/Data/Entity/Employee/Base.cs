using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Employee
{
    public class Base
    {
        public int id { get; set; }

        public Guid key { get; set; }

        public bool isDelete { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public DateTime deletedAt { get; set; }

        [StringLength(100)]
        public string createdBy { get; set; }

        [StringLength(100)]
        public string updatedBy { get; set; }

        [StringLength(500)]
        public string remarks { get; set; }
    }
}
