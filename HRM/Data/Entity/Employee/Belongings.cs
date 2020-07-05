using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("Belongings", Schema = "HR")]
    public class Belongings
    {
        public int id { get; set; }

        public int employeeId { get; set; }  //Fk

        [MaxLength(70)]
        public string assetNo { get; set; }

        public string itemName { get; set; }

        public string itemSpecification { get; set; }

        [MaxLength(400)]
        public string description { get; set; }

        public DateTime? issueDate { get; set; }

        public DateTime? returnDate { get; set; }

        public int? shortOrder { get; set; }
    }
}
