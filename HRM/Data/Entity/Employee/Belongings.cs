using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("Belongings", Schema = "HR")]
    public class Belongings:Base
    {
        public int employeeId { get; set; }  //Fk

        [MaxLength(100)]
        public string assetNo { get; set; }

        [StringLength(200)]
        public string itemName { get; set; }

        [StringLength(500)]
        public string itemSpecification { get; set; }

        [MaxLength(500)]
        public string description { get; set; }

        public DateTime? issueDate { get; set; }

        public DateTime? returnDate { get; set; }

        public int? shortOrder { get; set; }
    }
}
