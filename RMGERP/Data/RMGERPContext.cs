using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Data.Entity.Employee;
using HRM.Data.Entity.Master;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace RMGERP.Data
{
    public class RMGERPContext:IdentityDbContext<ApplicationUser>
    {
        public RMGERPContext(DbContextOptions<RMGERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcrInfo> AcrInfos { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BankInfo> BankInfos { get; set; }
      
        public virtual DbSet<Belongings> Belongingses { get; set; }
        public virtual DbSet<Children> Childrens { get; set; }
        public virtual DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public virtual DbSet<EducationalQualification> EducationalQualifications { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<EmployeeAward> EmployeeAwards { get; set; }
        public virtual DbSet<EmployeeContractInfo> EmployeeContractInfos { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
        public virtual DbSet<EmployeeMembership> EmployeeMemberships { get; set; }
        public virtual DbSet<EmployeeProjectActivity> EmployeeProjectActivities { get; set; }
        public virtual DbSet<FreedomFighter> FreedomFighters   { get; set; }
        public virtual DbSet<LeaveLog> LeaveLogs { get; set; }
        public virtual DbSet<Nominee> Nominees { get; set; }
        public virtual DbSet<NomineeDetail> NomineeDetails { get; set; }
        public virtual DbSet<OtherActivity> OtherActivities { get; set; }
        public virtual DbSet<OtherQualification> OtherQualifications { get; set; }
        public virtual DbSet<PassportDetails> PassportDetailses { get; set; }
        public virtual DbSet<Photograph> Photographs { get; set; }
        public virtual DbSet<PreviousEmployment> PreviousEmployments { get; set; }
        public virtual DbSet<ProfessionalQualifications> ProfessionalQualificationses   { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionLog> PromotionLogs     { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Spouse> Spouses { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<TransferLog> TransferLogs { get; set; }
        public virtual DbSet<TravelInfo> TravelInfos { get; set; }

        // Master folder classes
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<BranchUnit> BranchUnits { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CourseTitle> CourseTitles { get; set; }
        public virtual DbSet<CompanyGroup> CompanyGroups { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes  { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<LevelOfEducation> LevelOfEducations { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<OtherQualificationHead> OtherQualificationHead { get; set; }
        public virtual DbSet<QualificationHead> QualificationHead { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<RelDegreeSubject> RelDegreeSubjects { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<SalaryGrade> SalaryGrades     { get; set; }
        public virtual DbSet<ShiftGroupDetail> ShiftGroupDetails { get; set; }
        public virtual DbSet<ShiftGroupMaster> ShiftGroupMasters { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Thana> Thanas { get; set; }
        public virtual DbSet<TrainingCategory> TrainingCategories { get; set; }
        public virtual DbSet<TravelPurpose> TravelPurposes { get; set; }
        public virtual DbSet<TravelVehicleType> TravelVehicleTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Year> Years { get; set; }

       // public virtual DbSet<Base> Base { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
