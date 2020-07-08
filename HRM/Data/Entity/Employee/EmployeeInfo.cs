using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRM.Data.Entity.Master;

namespace HRM.Data.Entity.Employee
{
    [Table("EmployeeInfo", Schema = "HR")]
    public class EmployeeInfo : Base
    {
        [Required]
        [MaxLength(50)]
        public string employeeCode { get; set; }

        [MaxLength(100)]
        public string nationalId { get; set; }

        [MaxLength(100)]
        public string birthIdentificationNo { get; set; }

        [MaxLength(250)]
        public string govtId { get; set; }

        [MaxLength(100)]
        public string gpfNomineeName { get; set; }

        [MaxLength(100)]
        public string gpfAcNo { get; set; }

        [MaxLength(100)]
        public string nameEn { get; set; }

        [MaxLength(100)]
        public string nameBn { get; set; }

        [MaxLength(100)]
        public string motherNameEn { get; set; }

        [MaxLength(100)]
        public string motherNameBn { get; set; }

        [MaxLength(100)]
        public string fatherNameEn { get; set; }

        [MaxLength(100)]
        public string fatherNameBn { get; set; }

        [MaxLength(100)]
        public string nationality { get; set; }

        [MaxLength(100)]
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

        [MaxLength(50)]
        public string  lprDate{ get; set; } //calculative From Date of Birth

        [MaxLength(50)]
        public string  prlStartDate{ get; set; } //calculative From Date of Birth

        [MaxLength(50)]
        public string  prlEndDate{ get; set; } //calculative From Date of Birth

        [MaxLength(20)]
        public string gender { get; set; }

        [MaxLength(100)]
        public string birthPlace { get; set; }

        [MaxLength(30)]
        public string maritalStatus { get; set; }

        public int?  religionId { get; set; }
        public Religion religion { get; set; }

        public int? employeeTypeId { get; set; }
        public EmployeeType employeeType { get; set; }

        public int? activityStatus { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }

        [MaxLength(100)]
        public string tin { get; set; }

        [MaxLength(50)]
        public string batch { get; set; }

        [MaxLength(20)]
        public string bloodGroup { get; set; }

        public bool freedomFighter { get; set; }

        [MaxLength(50)]
        public string freedomFighterNo { get; set; }

        [MaxLength(20)]
        public string telephoneOffice { get; set; }

        [MaxLength(20)]
        public string telephoneResidence { get; set; }

        [MaxLength(50)]
        public string pabx { get; set; }

        [MaxLength(50)]
        public string emailAddress { get; set; }

        [MaxLength(50)]
        public string emailAddressPersonal { get; set; } // Next generated not planned

        [MaxLength(50)]
        public string mobileNumberOffice { get; set; }

        [MaxLength(50)]
        public string mobileNumberPersonal { get; set; }

        [MaxLength(300)]
        public string specialSkill { get; set; }
       
        [MaxLength(50)]
        public string seniorityNumber { get; set; }

        [MaxLength(50)]
        public string designation { get; set; }

        public int? post { get; set; } // Related PostID But Not FK Referenced 

        public int designationCheck { get; set; } //Current Charged Checked

        [MaxLength(50)]
        public string joiningDesignation { get; set; }
        
        [MaxLength(100)]
        public string natureOfReqruitment { get; set; } // Direct Or Absorbed

        [MaxLength(50)]
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
