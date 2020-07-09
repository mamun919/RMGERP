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

        public virtual DbSet<AcrInfo> acrInfos { get; set; }
        public virtual DbSet<Address> addresses { get; set; }
        public virtual DbSet<BankInfo> bankInfos { get; set; }
        public virtual DbSet <Base> Base { get; set; }
        public virtual DbSet<Belongings> belongingses { get; set; }
        public virtual DbSet<Children> childrens { get; set; }
        public virtual DbSet<DrivingLicense> drivingLicenses { get; set; }
        public virtual DbSet<EducationalQualification> educationalQualifications { get; set; }
        public virtual DbSet<EmergencyContact> emergencyContacts { get; set; }
        public virtual DbSet<EmployeeAward> employeeAwards { get; set; }
        public virtual DbSet<EmployeeContractInfo> employeeContractInfos { get; set; }
        public virtual DbSet<EmployeeInfo> employeeInfos { get; set; }
        public virtual DbSet<EmployeeLanguage> employeeLanguages { get; set; }
        public virtual DbSet<EmployeeMembership> employeeMemberships { get; set; }
        public virtual DbSet<EmployeeProjectActivity> employeeProjectActivities { get; set; }
        public virtual DbSet<FreedomFighter> freedomFighters   { get; set; }
        public virtual DbSet<LeaveLog> leaveLogs { get; set; }
        public virtual DbSet<Nominee> nominees { get; set; }
        public virtual DbSet<NomineeDetail> nomineeDetails { get; set; }
        public virtual DbSet<OtherActivity> otherActivities { get; set; }
        public virtual DbSet<OtherQualification> otherQualifications { get; set; }
        public virtual DbSet<PassportDetails> passportDetailses { get; set; }
        public virtual DbSet<Photograph> photographs { get; set; }
        public virtual DbSet<PreviousEmployment> previousEmployments { get; set; }
        public virtual DbSet<ProfessionalQualifications> professionalQualificationses   { get; set; }
        public virtual DbSet<Promotion> promotions { get; set; }
        public virtual DbSet<PromotionLog> promotionLogs     { get; set; }
        public virtual DbSet<Publication> publications { get; set; }
        public virtual DbSet<Reference> references { get; set; }
        public virtual DbSet<Spouse> spouses { get; set; }
        public virtual DbSet<Supervisor> supervisors { get; set; }
        public virtual DbSet<TransferLog> transferLogs { get; set; }
        public virtual DbSet<TravelInfo> travelInfos { get; set; }

        // Master folder classes
        public virtual DbSet<AddressType> addressTypes { get; set; }
        public virtual DbSet<BranchUnit> branchUnits { get; set; }
        public virtual DbSet<Company> companies { get; set; }
        public virtual DbSet<CourseTitle> courseTitles { get; set; }
        public virtual DbSet<CompanyGroup> companyGroups { get; set; }
        public virtual DbSet<CompanyAddress> companyAddresses { get; set; }
        public virtual DbSet<Country> countries { get; set; }
        public virtual DbSet<Degree> degrees { get; set; }
        public virtual DbSet<Department> departments { get; set; }
        public virtual DbSet<Designation> designations { get; set; }
        public virtual DbSet<District> districts { get; set; }
        public virtual DbSet<Division> divisions { get; set; }
        public virtual DbSet<EmployeeType> employeeTypes  { get; set; }
        public virtual DbSet<Holiday> holidays { get; set; }
        public virtual DbSet<Language> languages { get; set; }
        public virtual DbSet<LeaveType> leaveTypes { get; set; }
        public virtual DbSet<LevelOfEducation> levelOfEducations { get; set; }
        public virtual DbSet<Membership> memberships { get; set; }
        public virtual DbSet<OtherQualificationHead> otherQualificationHead { get; set; }
        public virtual DbSet<QualificationHead> qualificationHead { get; set; }
        public virtual DbSet<Relation> relations { get; set; }
        public virtual DbSet<RelDegreeSubject> relDegreeSubjects { get; set; }
        public virtual DbSet<Religion> religions { get; set; }
        public virtual DbSet<Result> results { get; set; }
        public virtual DbSet<SalaryGrade> salaryGrades     { get; set; }
        public virtual DbSet<ShiftGroupDetail> shiftGroupDetails { get; set; }
        public virtual DbSet<ShiftGroupMaster> shiftGroupMasters { get; set; }
        public virtual DbSet<Subject> subjects { get; set; }
        public virtual DbSet<Thana> thanas { get; set; }
        public virtual DbSet<TrainingCategory> trainingCategories { get; set; }
        public virtual DbSet<TravelPurpose> travelPurposes { get; set; }
        public virtual DbSet<TravelVehicleType> travelVehicleTypes { get; set; }
        public virtual DbSet<Vehicle> vehicles { get; set; }
        public virtual DbSet<Year> years { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
