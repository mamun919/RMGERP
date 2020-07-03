using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Data.Entity.Employee
{
    [NotMapped]
    public class EmployeeAvailablePosts
    {
        public int postId { get; set; }
        public int? orgId { get; set; }
        public string designationName { get; set; }
    }
}
