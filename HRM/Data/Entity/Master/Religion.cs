﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Data.Entity.Master
{
    [Table("Religion", Schema = "HR")]
    public class Religion
    {
        [Required]
        public string name { get; set; }
        public string nameBn { get; set; }

        public string shortName { get; set; }
    }
}