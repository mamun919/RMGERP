using System;
using System.ComponentModel.DataAnnotations;
using HRM.Data.Entity.Employee;

namespace HRM.Data.Entity.Master
{
    public class Company: Base
    {
        [MaxLength(100)]
        public string companyName { get; set; }

        [MaxLength(50)]
        public string ownerName { get; set; }

        [MaxLength(50)]
        public string managerName { get; set; }

        [MaxLength(100)]
        public string tradeLicense { get; set; }

        [MaxLength(250)]
        public string businessNature { get; set; }

        [MaxLength(30)]
        public string officeTelephone { get; set; }

        [MaxLength(50)]
        public string vatNo { get; set; }

        [MaxLength(50)]
        public string tinNo { get; set; }

        public DateTime? dateOfEstablishment { get; set; }

        public int? permanentEmployee { get; set; }
        [MaxLength(50)]
        public string companyEmail { get; set; }
        [MaxLength(50)]
        public string alternateEmail { get; set; }

        public decimal? liquidityRatio { get; set; }
        [MaxLength(250)]
        public string fileName { get; set; }
        [MaxLength(500)]
        public string filePath { get; set; }

        [MaxLength(500)]
        public string logoUrl { get; set; }
    }
}
