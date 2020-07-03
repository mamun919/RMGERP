using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Data.Entity.Master
{
    public class Company
    {
        [MaxLength(250)]
        public string companyName { get; set; }
        [MaxLength(250)]
        public string ownerName { get; set; }
        [MaxLength(250)]
        public string managerName { get; set; }
        [MaxLength(250)]
        public string tradeLicense { get; set; }
        [MaxLength(250)]
        public string businessNature { get; set; }
        [MaxLength(150)]
        public string officeTelephone { get; set; }
        [MaxLength(150)]
        public string vatNo { get; set; }
        [MaxLength(150)]
        public string tinNo { get; set; }

        public DateTime? dateOfEstablishment { get; set; }

        public int? permanentEmployee { get; set; }
        [MaxLength(150)]
        public string companyEmail { get; set; }
        [MaxLength(150)]
        public string alternetEmail { get; set; }

        public decimal? liquidityRatio { get; set; }
        [MaxLength(250)]
        public string fileName { get; set; }
        [MaxLength(500)]
        public string filePath { get; set; }
    }
}
