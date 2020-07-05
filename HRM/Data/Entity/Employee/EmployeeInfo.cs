using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeInfo", Schema = "HR")]
    public class EmployeeInfo 
    {
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string employeeCode { get; set; }

        [MaxLength(100)]
        public string nationalId { get; set; }

        [MaxLength(100)]
        public string birthIdentificationNo { get; set; }

        [MaxLength(250)]
        public string govtId { get; set; }
        
        public string gpfNomineeName { get; set; }
        
        public string gpfAcNo { get; set; }

        public string nameEn { get; set; }

        public string nameBn { get; set; }

        public string motherNameEn { get; set; }

        public string motherNameBn { get; set; }

        public string fatherNameEn { get; set; }

        public string fatherNameBn { get; set; }

        public string nationality { get; set; }

        public string disability { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? joiningDatePresentWorkstation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? joiningDateGovtService { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfRegularity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfPermanent { get; set; }
        
        public string  lprDate{ get; set; } //calculative From Date of Birth

        public string  prlStartDate{ get; set; } //calculative From Date of Birth
        public string  prlEndDate{ get; set; } //calculative From Date of Birth

        public string gender { get; set; }

        public string birthPlace { get; set; }

        public string maritalStatus { get; set; }

        public int?  religionId { get; set; }
        public Religion religion { get; set; }

        public int? employeeTypeId { get; set; }
        public EmployeeType employeeType { get; set; }

        public int? activityStatus { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }

        public string tin { get; set; }

        public string batch { get; set; }

        public string bloodGroup { get; set; }

        public bool freedomFighter { get; set; }

        public string freedomFighterNo { get; set; }
      
        public string telephoneOffice { get; set; }
       
        public string telephoneResidence { get; set; }
       
        public string pabx { get; set; }
       
        public string emailAddress { get; set; }

        public string emailAddressPersonal { get; set; } // Next generated not planned

        [MaxLength(50)]
        public string mobileNumberOffice { get; set; }

        [MaxLength(50)]
        public string mobileNumberPersonal { get; set; }

        public string specialSkill { get; set; }
       
        [MaxLength(50)]
        public string seniorityNumber { get; set; }

        public string designation { get; set; }

        public int? post { get; set; } // Related PostID But Not FK Referenced 

        public int designationCheck { get; set; } //Current Charged Checked

        public string joiningDesignation { get; set; }
        
        [MaxLength(100)]
        public string natureOfReqruitment { get; set; } // Direct Or Absorbed

        public string homeDistrict { get; set; }

        public int? branchId { get; set; }
        public BranchUnit branch { get; set; }

        //For Type Managing 
        [MaxLength(100)]
        public string orgType { get; set; }

        //Application User LInk
        //public String ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

    }
}
