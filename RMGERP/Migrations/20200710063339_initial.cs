using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMGERP.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.EnsureSchema(
                name: "Payroll");

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    typeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    companyName = table.Column<string>(maxLength: 100, nullable: true),
                    ownerName = table.Column<string>(maxLength: 50, nullable: true),
                    managerName = table.Column<string>(maxLength: 50, nullable: true),
                    tradeLicense = table.Column<string>(maxLength: 100, nullable: true),
                    businessNature = table.Column<string>(maxLength: 250, nullable: true),
                    officeTelephone = table.Column<string>(maxLength: 30, nullable: true),
                    vatNo = table.Column<string>(maxLength: 50, nullable: true),
                    tinNo = table.Column<string>(maxLength: 50, nullable: true),
                    dateOfEstablishment = table.Column<DateTime>(nullable: true),
                    permanentEmployee = table.Column<int>(nullable: true),
                    companyEmail = table.Column<string>(maxLength: 50, nullable: true),
                    alternateEmail = table.Column<string>(maxLength: 50, nullable: true),
                    liquidityRatio = table.Column<decimal>(nullable: true),
                    fileName = table.Column<string>(maxLength: 250, nullable: true),
                    filePath = table.Column<string>(maxLength: 500, nullable: true),
                    logoUrl = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    countryCode = table.Column<string>(maxLength: 50, nullable: false),
                    countryName = table.Column<string>(maxLength: 50, nullable: false),
                    countryNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    shortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Belongings",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    assetNo = table.Column<string>(maxLength: 100, nullable: true),
                    itemName = table.Column<string>(maxLength: 200, nullable: true),
                    itemSpecification = table.Column<string>(maxLength: 500, nullable: true),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    issueDate = table.Column<DateTime>(nullable: true),
                    returnDate = table.Column<DateTime>(nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belongings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CourseTitle",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    nameEn = table.Column<string>(maxLength: 50, nullable: true),
                    nameBn = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTitle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    deptCode = table.Column<string>(maxLength: 50, nullable: true),
                    deptName = table.Column<string>(maxLength: 50, nullable: false),
                    deptNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    shortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    designationCode = table.Column<string>(maxLength: 50, nullable: false),
                    designationName = table.Column<string>(maxLength: 50, nullable: false),
                    designationNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    shortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    empType = table.Column<string>(maxLength: 50, nullable: false),
                    empTypeBn = table.Column<string>(maxLength: 50, nullable: true),
                    shortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    weeklyHoliday = table.Column<string>(maxLength: 30, nullable: false),
                    holidayName = table.Column<string>(maxLength: 30, nullable: false),
                    holidayNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    languageName = table.Column<string>(maxLength: 30, nullable: false),
                    languageNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    languageShortName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    nameEn = table.Column<string>(maxLength: 50, nullable: false),
                    nameBn = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LevelOfEducation",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    levelOfEducationName = table.Column<string>(maxLength: 50, nullable: false),
                    levelOfEducationNameBn = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelOfEducation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Membership",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    membershipName = table.Column<string>(maxLength: 50, nullable: false),
                    membershipNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    membershipShortName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OtherQualificationHead",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherQualificationHead", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QualificationHead",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualificationHead", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    relationName = table.Column<string>(maxLength: 30, nullable: false),
                    relationNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    relationShortName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    name = table.Column<string>(maxLength: 20, nullable: false),
                    nameBn = table.Column<string>(maxLength: 20, nullable: true),
                    shortName = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    resultName = table.Column<string>(maxLength: 50, nullable: false),
                    resultNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    resultShortName = table.Column<string>(maxLength: 50, nullable: true),
                    resultMaxValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftGroupMaster",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    shiftName = table.Column<string>(maxLength: 50, nullable: false),
                    shiftNameBn = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftGroupMaster", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    subjectName = table.Column<string>(maxLength: 50, nullable: false),
                    subjectNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    subjectShortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCategory",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    trainingCategoryName = table.Column<string>(maxLength: 100, nullable: false),
                    trainingCategoryNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    trainingCategoryShortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TravelPurpose",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    purposeName = table.Column<string>(maxLength: 100, nullable: false),
                    purposeNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    purposeShortName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPurpose", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TravelVehicleType",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelVehicleType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    vehicleType = table.Column<string>(maxLength: 50, nullable: false),
                    vehicleTypeBn = table.Column<string>(maxLength: 60, nullable: true),
                    vehicleShortName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Year",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    year = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Year", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryGrade",
                schema: "Payroll",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    gradeName = table.Column<string>(maxLength: 100, nullable: true),
                    basicAmount = table.Column<decimal>(nullable: false),
                    payScale = table.Column<string>(maxLength: 100, nullable: true),
                    currentBasic = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryGrade", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyGroups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    groupName = table.Column<string>(maxLength: 50, nullable: true),
                    companyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyGroups", x => x.id);
                    table.ForeignKey(
                        name: "FK_CompanyGroups_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchUnit",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    branchUnitName = table.Column<string>(maxLength: 100, nullable: true),
                    branchUnitNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    branchCode = table.Column<string>(maxLength: 100, nullable: true),
                    companyId = table.Column<int>(nullable: true),
                    shortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchUnit", x => x.id);
                    table.ForeignKey(
                        name: "FK_BranchUnit_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    divisionCode = table.Column<string>(maxLength: 50, nullable: false),
                    divisionName = table.Column<string>(maxLength: 20, nullable: false),
                    divisionNameBn = table.Column<string>(maxLength: 20, nullable: true),
                    shortName = table.Column<string>(maxLength: 20, nullable: true),
                    countryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Divisions_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    degreeName = table.Column<string>(maxLength: 30, nullable: false),
                    degreeNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    degreeShortName = table.Column<string>(maxLength: 30, nullable: true),
                    levelOfEducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.id);
                    table.ForeignKey(
                        name: "FK_Degree_LevelOfEducation_levelOfEducationId",
                        column: x => x.levelOfEducationId,
                        principalSchema: "HR",
                        principalTable: "LevelOfEducation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftGroupDetail",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    weekDay = table.Column<string>(maxLength: 20, nullable: false),
                    startTime = table.Column<string>(maxLength: 30, nullable: false),
                    endTime = table.Column<string>(maxLength: 30, nullable: false),
                    holiday = table.Column<bool>(nullable: false),
                    shiftGroupMasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftGroupDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShiftGroupDetail_ShiftGroupMaster_shiftGroupMasterId",
                        column: x => x.shiftGroupMasterId,
                        principalSchema: "HR",
                        principalTable: "ShiftGroupMaster",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeCode = table.Column<string>(maxLength: 50, nullable: false),
                    nationalId = table.Column<string>(maxLength: 100, nullable: true),
                    birthIdentificationNo = table.Column<string>(maxLength: 100, nullable: true),
                    govtId = table.Column<string>(maxLength: 250, nullable: true),
                    gpfNomineeName = table.Column<string>(maxLength: 100, nullable: true),
                    gpfAcNo = table.Column<string>(maxLength: 100, nullable: true),
                    nameEn = table.Column<string>(maxLength: 100, nullable: true),
                    nameBn = table.Column<string>(maxLength: 100, nullable: true),
                    motherNameEn = table.Column<string>(maxLength: 100, nullable: true),
                    motherNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    fatherNameEn = table.Column<string>(maxLength: 100, nullable: true),
                    fatherNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    nationality = table.Column<string>(maxLength: 100, nullable: true),
                    disability = table.Column<string>(maxLength: 100, nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    joiningDatePresentWorkstation = table.Column<DateTime>(nullable: true),
                    joiningDateGovtService = table.Column<DateTime>(nullable: true),
                    dateOfRegularity = table.Column<DateTime>(nullable: true),
                    dateOfPermanent = table.Column<DateTime>(nullable: true),
                    lprDate = table.Column<string>(maxLength: 50, nullable: true),
                    prlStartDate = table.Column<string>(maxLength: 50, nullable: true),
                    prlEndDate = table.Column<string>(maxLength: 50, nullable: true),
                    gender = table.Column<string>(maxLength: 20, nullable: true),
                    birthPlace = table.Column<string>(maxLength: 100, nullable: true),
                    maritalStatus = table.Column<string>(maxLength: 30, nullable: true),
                    religionId = table.Column<int>(nullable: true),
                    employeeTypeId = table.Column<int>(nullable: true),
                    activityStatus = table.Column<int>(nullable: true),
                    departmentId = table.Column<int>(nullable: true),
                    tin = table.Column<string>(maxLength: 100, nullable: true),
                    batch = table.Column<string>(maxLength: 50, nullable: true),
                    bloodGroup = table.Column<string>(maxLength: 20, nullable: true),
                    freedomFighter = table.Column<bool>(nullable: false),
                    freedomFighterNo = table.Column<string>(maxLength: 50, nullable: true),
                    telephoneOffice = table.Column<string>(maxLength: 20, nullable: true),
                    telephoneResidence = table.Column<string>(maxLength: 20, nullable: true),
                    pabx = table.Column<string>(maxLength: 50, nullable: true),
                    emailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    emailAddressPersonal = table.Column<string>(maxLength: 50, nullable: true),
                    mobileNumberOffice = table.Column<string>(maxLength: 50, nullable: true),
                    mobileNumberPersonal = table.Column<string>(maxLength: 50, nullable: true),
                    specialSkill = table.Column<string>(maxLength: 300, nullable: true),
                    seniorityNumber = table.Column<string>(maxLength: 50, nullable: true),
                    designation = table.Column<string>(maxLength: 50, nullable: true),
                    post = table.Column<int>(nullable: true),
                    designationCheck = table.Column<int>(nullable: false),
                    joiningDesignation = table.Column<string>(maxLength: 50, nullable: true),
                    natureOfReqruitment = table.Column<string>(maxLength: 100, nullable: true),
                    homeDistrict = table.Column<string>(maxLength: 50, nullable: true),
                    branchId = table.Column<int>(nullable: true),
                    orgType = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_BranchUnit_branchId",
                        column: x => x.branchId,
                        principalSchema: "HR",
                        principalTable: "BranchUnit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Department_departmentId",
                        column: x => x.departmentId,
                        principalSchema: "HR",
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_EmployeeType_employeeTypeId",
                        column: x => x.employeeTypeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Religion_religionId",
                        column: x => x.religionId,
                        principalSchema: "HR",
                        principalTable: "Religion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    districtCode = table.Column<string>(maxLength: 30, nullable: false),
                    districtName = table.Column<string>(maxLength: 30, nullable: false),
                    districtNameBn = table.Column<string>(maxLength: 30, nullable: true),
                    shortName = table.Column<string>(maxLength: 30, nullable: true),
                    divisionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Districts_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelDegreeSubject",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    degreeId = table.Column<int>(nullable: false),
                    subjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelDegreeSubject", x => x.id);
                    table.ForeignKey(
                        name: "FK_RelDegreeSubject_Degree_degreeId",
                        column: x => x.degreeId,
                        principalSchema: "HR",
                        principalTable: "Degree",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelDegreeSubject_Subject_subjectId",
                        column: x => x.subjectId,
                        principalSchema: "HR",
                        principalTable: "Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcrInfo",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    startDate = table.Column<string>(nullable: true),
                    endDate = table.Column<string>(nullable: true),
                    supervisorName = table.Column<string>(maxLength: 250, nullable: true),
                    supervisorDesg = table.Column<string>(maxLength: 100, nullable: true),
                    signatoryName = table.Column<string>(maxLength: 250, nullable: true),
                    signatoryDesg = table.Column<string>(maxLength: 100, nullable: true),
                    year = table.Column<string>(maxLength: 10, nullable: true),
                    advanceComment = table.Column<string>(nullable: true),
                    score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcrInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_AcrInfo_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankInfo",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    bankName = table.Column<string>(maxLength: 100, nullable: true),
                    branchName = table.Column<string>(maxLength: 100, nullable: true),
                    accountNumber = table.Column<string>(maxLength: 100, nullable: true),
                    ibus = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_BankInfo_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    childName = table.Column<string>(maxLength: 100, nullable: true),
                    childNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    education = table.Column<string>(maxLength: 100, nullable: true),
                    gender = table.Column<string>(maxLength: 50, nullable: true),
                    bin = table.Column<string>(maxLength: 100, nullable: true),
                    occupation = table.Column<string>(maxLength: 100, nullable: true),
                    designation = table.Column<string>(maxLength: 100, nullable: true),
                    organization = table.Column<string>(maxLength: 200, nullable: true),
                    nid = table.Column<string>(maxLength: 100, nullable: true),
                    bloodGroup = table.Column<string>(maxLength: 50, nullable: true),
                    disability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.id);
                    table.ForeignKey(
                        name: "FK_Children_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicense",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    licenseNumber = table.Column<string>(maxLength: 200, nullable: true),
                    category = table.Column<string>(maxLength: 100, nullable: true),
                    placeOfIssue = table.Column<string>(maxLength: 200, nullable: true),
                    dateOfIssue = table.Column<DateTime>(nullable: true),
                    dateOfExpire = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicense", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrivingLicense_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    relation = table.Column<string>(maxLength: 100, nullable: true),
                    designation = table.Column<string>(maxLength: 100, nullable: true),
                    organization = table.Column<string>(maxLength: 100, nullable: true),
                    contact = table.Column<string>(maxLength: 100, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmergencyContact_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAward",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    awardName = table.Column<string>(maxLength: 100, nullable: true),
                    purpose = table.Column<string>(maxLength: 100, nullable: true),
                    awardDate = table.Column<DateTime>(nullable: true),
                    issuedBy = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAward", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeAward_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeContractInfo",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: true),
                    contractStartDate = table.Column<DateTime>(nullable: true),
                    contractEndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeContractInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeContractInfo_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLanguage",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    reading = table.Column<string>(maxLength: 50, nullable: true),
                    writing = table.Column<string>(maxLength: 50, nullable: true),
                    speaking = table.Column<string>(maxLength: 50, nullable: true),
                    languageId = table.Column<int>(nullable: true),
                    proficiency = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLanguage", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguage_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguage_Language_languageId",
                        column: x => x.languageId,
                        principalSchema: "HR",
                        principalTable: "Language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMembership",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    nameOfOrganization = table.Column<string>(maxLength: 100, nullable: true),
                    membershipNo = table.Column<string>(maxLength: 100, nullable: true),
                    membershipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMembership", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeMembership_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeMembership_Membership_membershipId",
                        column: x => x.membershipId,
                        principalSchema: "HR",
                        principalTable: "Membership",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjectActivity",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: true),
                    isActive = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjectActivity", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectActivity_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreedomFighter",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    number = table.Column<string>(maxLength: 100, nullable: true),
                    owner = table.Column<string>(maxLength: 100, nullable: true),
                    relationship = table.Column<string>(maxLength: 100, nullable: true),
                    sectorNo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreedomFighter", x => x.id);
                    table.ForeignKey(
                        name: "FK_FreedomFighter_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveLog",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    leaveTypeId = table.Column<int>(nullable: true),
                    leaveFrom = table.Column<DateTime>(nullable: false),
                    leaveTo = table.Column<DateTime>(nullable: false),
                    purposeOfLeave = table.Column<string>(maxLength: 100, nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeaveLog_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveLog_LeaveType_leaveTypeId",
                        column: x => x.leaveTypeId,
                        principalSchema: "HR",
                        principalTable: "LeaveType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nominee",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    address = table.Column<string>(maxLength: 150, nullable: true),
                    relation = table.Column<string>(maxLength: 100, nullable: true),
                    contact = table.Column<string>(maxLength: 100, nullable: true),
                    nid = table.Column<string>(maxLength: 100, nullable: true),
                    brn = table.Column<string>(maxLength: 100, nullable: true),
                    imageUrl = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominee", x => x.id);
                    table.ForeignKey(
                        name: "FK_Nominee_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherActivity",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    activityName = table.Column<string>(maxLength: 100, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherActivity", x => x.id);
                    table.ForeignKey(
                        name: "FK_OtherActivity_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherQualification",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    otherQualificationHeadId = table.Column<int>(nullable: true),
                    subject = table.Column<string>(maxLength: 50, nullable: true),
                    resultId = table.Column<int>(nullable: true),
                    instituteName = table.Column<string>(maxLength: 100, nullable: true),
                    passingYear = table.Column<string>(maxLength: 20, nullable: true),
                    markGrade = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherQualification", x => x.id);
                    table.ForeignKey(
                        name: "FK_OtherQualification_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherQualification_OtherQualificationHead_otherQualificationHeadId",
                        column: x => x.otherQualificationHeadId,
                        principalSchema: "HR",
                        principalTable: "OtherQualificationHead",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherQualification_Result_resultId",
                        column: x => x.resultId,
                        principalSchema: "HR",
                        principalTable: "Result",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PassportDetails",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    passportNumber = table.Column<string>(maxLength: 100, nullable: true),
                    placeOfIssue = table.Column<string>(maxLength: 100, nullable: true),
                    dateOfIssue = table.Column<DateTime>(nullable: true),
                    dateOfExpair = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_PassportDetails_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photograph",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    url = table.Column<string>(maxLength: 200, nullable: false),
                    type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photograph", x => x.id);
                    table.ForeignKey(
                        name: "FK_Photograph_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousEmployment",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    companyName = table.Column<string>(maxLength: 100, nullable: true),
                    position = table.Column<string>(maxLength: 50, nullable: true),
                    department = table.Column<string>(maxLength: 50, nullable: true),
                    companyBusiness = table.Column<string>(maxLength: 100, nullable: true),
                    startDate = table.Column<DateTime>(nullable: true),
                    endDate = table.Column<DateTime>(nullable: true),
                    companyLocation = table.Column<string>(maxLength: 100, nullable: true),
                    responsibilities = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousEmployment", x => x.id);
                    table.ForeignKey(
                        name: "FK_PreviousEmployment_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalQualifications",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    qualificationHeadId = table.Column<int>(nullable: true),
                    subject = table.Column<string>(maxLength: 100, nullable: true),
                    resultId = table.Column<int>(nullable: true),
                    instituteName = table.Column<string>(maxLength: 100, nullable: true),
                    passingYear = table.Column<string>(maxLength: 20, nullable: true),
                    markGrade = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalQualifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualifications_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualifications_QualificationHead_qualificationHeadId",
                        column: x => x.qualificationHeadId,
                        principalSchema: "HR",
                        principalTable: "QualificationHead",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualifications_Result_resultId",
                        column: x => x.resultId,
                        principalSchema: "HR",
                        principalTable: "Result",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    employeeInfoid = table.Column<int>(nullable: true),
                    promotionType = table.Column<string>(maxLength: 100, nullable: true),
                    designationId = table.Column<int>(nullable: true),
                    promotionDate = table.Column<string>(maxLength: 20, nullable: true),
                    salaryGradeId = table.Column<int>(nullable: true),
                    basic = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Promotion_Designation_designationId",
                        column: x => x.designationId,
                        principalSchema: "HR",
                        principalTable: "Designation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promotion_EmployeeInfo_employeeInfoid",
                        column: x => x.employeeInfoid,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promotion_SalaryGrade_salaryGradeId",
                        column: x => x.salaryGradeId,
                        principalSchema: "Payroll",
                        principalTable: "SalaryGrade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromotionLog",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    designation = table.Column<string>(maxLength: 50, nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    payScaleId = table.Column<int>(nullable: true),
                    goNumber = table.Column<string>(maxLength: 100, nullable: true),
                    goDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_PromotionLog_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionLog_SalaryGrade_payScaleId",
                        column: x => x.payScaleId,
                        principalSchema: "Payroll",
                        principalTable: "SalaryGrade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publication",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    publicationName = table.Column<string>(maxLength: 100, nullable: true),
                    publicationType = table.Column<string>(maxLength: 50, nullable: true),
                    publicationPlace = table.Column<string>(maxLength: 100, nullable: true),
                    publicationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publication", x => x.id);
                    table.ForeignKey(
                        name: "FK_Publication_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    designation = table.Column<string>(maxLength: 50, nullable: true),
                    organization = table.Column<string>(maxLength: 100, nullable: true),
                    contact = table.Column<string>(maxLength: 30, nullable: true),
                    email = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reference_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spouse",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    spouseName = table.Column<string>(maxLength: 50, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    spouseNameBn = table.Column<string>(maxLength: 100, nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    occupation = table.Column<string>(maxLength: 50, nullable: true),
                    gender = table.Column<string>(maxLength: 20, nullable: true),
                    designation = table.Column<string>(maxLength: 40, nullable: true),
                    organization = table.Column<string>(maxLength: 100, nullable: true),
                    bin = table.Column<string>(maxLength: 100, nullable: true),
                    nid = table.Column<string>(maxLength: 50, nullable: true),
                    bloodGroup = table.Column<string>(maxLength: 10, nullable: true),
                    contact = table.Column<string>(maxLength: 30, nullable: true),
                    highestEducation = table.Column<string>(maxLength: 50, nullable: true),
                    homeDistrict = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spouse", x => x.id);
                    table.ForeignKey(
                        name: "FK_Spouse_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    supervisorId = table.Column<int>(nullable: true),
                    commandOrder = table.Column<string>(maxLength: 100, nullable: true),
                    canFinalApprover = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Supervisor_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supervisor_EmployeeInfo_supervisorId",
                        column: x => x.supervisorId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferLog",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    workStation = table.Column<string>(maxLength: 100, nullable: true),
                    from = table.Column<DateTime>(nullable: true),
                    to = table.Column<DateTime>(nullable: true),
                    designationId = table.Column<int>(nullable: true),
                    departmentId = table.Column<int>(nullable: true),
                    salaryGradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_TransferLog_Department_departmentId",
                        column: x => x.departmentId,
                        principalSchema: "HR",
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferLog_Designation_designationId",
                        column: x => x.designationId,
                        principalSchema: "HR",
                        principalTable: "Designation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferLog_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferLog_SalaryGrade_salaryGradeId",
                        column: x => x.salaryGradeId,
                        principalSchema: "Payroll",
                        principalTable: "SalaryGrade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TravelInfo",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    travelPurposeId = table.Column<int>(nullable: true),
                    purpose = table.Column<string>(maxLength: 100, nullable: true),
                    location = table.Column<string>(maxLength: 100, nullable: true),
                    countryId = table.Column<int>(nullable: true),
                    sponsoringAgency = table.Column<string>(maxLength: 100, nullable: true),
                    startDate = table.Column<DateTime>(nullable: true),
                    endDate = table.Column<DateTime>(nullable: true),
                    goNumber = table.Column<string>(maxLength: 100, nullable: true),
                    goDate = table.Column<string>(maxLength: 100, nullable: true),
                    file = table.Column<string>(maxLength: 100, nullable: true),
                    titleOfFile = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_TravelInfo_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TravelInfo_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelInfo_TravelPurpose_travelPurposeId",
                        column: x => x.travelPurposeId,
                        principalSchema: "HR",
                        principalTable: "TravelPurpose",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thanas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    thanaCode = table.Column<string>(maxLength: 50, nullable: true),
                    thanaName = table.Column<string>(maxLength: 50, nullable: true),
                    shortName = table.Column<string>(maxLength: 50, nullable: true),
                    thanaNameBn = table.Column<string>(maxLength: 50, nullable: true),
                    districtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Thanas_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalQualification",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    institution = table.Column<string>(maxLength: 100, nullable: true),
                    resultId = table.Column<int>(nullable: true),
                    majorGroup = table.Column<string>(maxLength: 100, nullable: true),
                    grade = table.Column<string>(maxLength: 100, nullable: true),
                    passingYear = table.Column<int>(nullable: true),
                    degreeId = table.Column<int>(nullable: true),
                    relDegreeSubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalQualification", x => x.id);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_Degree_degreeId",
                        column: x => x.degreeId,
                        principalSchema: "HR",
                        principalTable: "Degree",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_RelDegreeSubject_relDegreeSubjectId",
                        column: x => x.relDegreeSubjectId,
                        principalSchema: "HR",
                        principalTable: "RelDegreeSubject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_Result_resultId",
                        column: x => x.resultId,
                        principalSchema: "HR",
                        principalTable: "Result",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NomineeDetail",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    nomineeId = table.Column<int>(nullable: true),
                    percentage = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NomineeDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_NomineeDetail_Nominee_nomineeId",
                        column: x => x.nomineeId,
                        principalSchema: "HR",
                        principalTable: "Nominee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAddresses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    addressTypeId = table.Column<int>(nullable: true),
                    countryId = table.Column<int>(nullable: true),
                    divisionId = table.Column<int>(nullable: true),
                    districtId = table.Column<int>(nullable: true),
                    thanaId = table.Column<int>(nullable: true),
                    union = table.Column<string>(maxLength: 50, nullable: true),
                    postOffice = table.Column<string>(maxLength: 50, nullable: true),
                    postCode = table.Column<string>(maxLength: 50, nullable: true),
                    blockSector = table.Column<string>(maxLength: 50, nullable: true),
                    houseVillage = table.Column<string>(maxLength: 100, nullable: true),
                    type = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_AddressTypes_addressTypeId",
                        column: x => x.addressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Thanas_thanaId",
                        column: x => x.thanaId,
                        principalTable: "Thanas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "HR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    key = table.Column<Guid>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    deletedAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    remarks = table.Column<string>(maxLength: 500, nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    countryId = table.Column<int>(nullable: true),
                    divisionId = table.Column<int>(nullable: true),
                    districtId = table.Column<int>(nullable: true),
                    thanaId = table.Column<int>(nullable: true),
                    union = table.Column<string>(maxLength: 100, nullable: true),
                    postOffice = table.Column<string>(maxLength: 100, nullable: true),
                    postCode = table.Column<string>(maxLength: 50, nullable: true),
                    blockSector = table.Column<string>(maxLength: 100, nullable: true),
                    houseVillage = table.Column<string>(maxLength: 200, nullable: true),
                    roadNumber = table.Column<string>(maxLength: 100, nullable: true),
                    type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.id);
                    table.ForeignKey(
                        name: "FK_Address_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Districts_districtId",
                        column: x => x.districtId,
                        principalTable: "Districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Divisions_divisionId",
                        column: x => x.divisionId,
                        principalTable: "Divisions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Thanas_thanaId",
                        column: x => x.thanaId,
                        principalTable: "Thanas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_addressTypeId",
                table: "CompanyAddresses",
                column: "addressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_countryId",
                table: "CompanyAddresses",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_districtId",
                table: "CompanyAddresses",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_divisionId",
                table: "CompanyAddresses",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_thanaId",
                table: "CompanyAddresses",
                column: "thanaId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyGroups_companyId",
                table: "CompanyGroups",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_divisionId",
                table: "Districts",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_countryId",
                table: "Divisions",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanas_districtId",
                table: "Thanas",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_AcrInfo_employeeId",
                schema: "HR",
                table: "AcrInfo",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_countryId",
                schema: "HR",
                table: "Address",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_districtId",
                schema: "HR",
                table: "Address",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_divisionId",
                schema: "HR",
                table: "Address",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_employeeId",
                schema: "HR",
                table: "Address",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_thanaId",
                schema: "HR",
                table: "Address",
                column: "thanaId");

            migrationBuilder.CreateIndex(
                name: "IX_BankInfo_employeeId",
                schema: "HR",
                table: "BankInfo",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchUnit_companyId",
                schema: "HR",
                table: "BranchUnit",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_employeeId",
                schema: "HR",
                table: "Children",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Degree_levelOfEducationId",
                schema: "HR",
                table: "Degree",
                column: "levelOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicense_employeeId",
                schema: "HR",
                table: "DrivingLicense",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_degreeId",
                schema: "HR",
                table: "EducationalQualification",
                column: "degreeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_employeeId",
                schema: "HR",
                table: "EducationalQualification",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_relDegreeSubjectId",
                schema: "HR",
                table: "EducationalQualification",
                column: "relDegreeSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_resultId",
                schema: "HR",
                table: "EducationalQualification",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_employeeId",
                schema: "HR",
                table: "EmergencyContact",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAward_employeeId",
                schema: "HR",
                table: "EmployeeAward",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeContractInfo_employeeId",
                schema: "HR",
                table: "EmployeeContractInfo",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_branchId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_departmentId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_employeeTypeId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "employeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_religionId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "religionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguage_employeeId",
                schema: "HR",
                table: "EmployeeLanguage",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguage_languageId",
                schema: "HR",
                table: "EmployeeLanguage",
                column: "languageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMembership_employeeId",
                schema: "HR",
                table: "EmployeeMembership",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMembership_membershipId",
                schema: "HR",
                table: "EmployeeMembership",
                column: "membershipId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectActivity_employeeId",
                schema: "HR",
                table: "EmployeeProjectActivity",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FreedomFighter_employeeId",
                schema: "HR",
                table: "FreedomFighter",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveLog_employeeId",
                schema: "HR",
                table: "LeaveLog",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveLog_leaveTypeId",
                schema: "HR",
                table: "LeaveLog",
                column: "leaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominee_employeeId",
                schema: "HR",
                table: "Nominee",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_NomineeDetail_nomineeId",
                schema: "HR",
                table: "NomineeDetail",
                column: "nomineeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherActivity_employeeId",
                schema: "HR",
                table: "OtherActivity",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherQualification_employeeId",
                schema: "HR",
                table: "OtherQualification",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherQualification_otherQualificationHeadId",
                schema: "HR",
                table: "OtherQualification",
                column: "otherQualificationHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherQualification_resultId",
                schema: "HR",
                table: "OtherQualification",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_PassportDetails_employeeId",
                schema: "HR",
                table: "PassportDetails",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photograph_employeeId",
                schema: "HR",
                table: "Photograph",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousEmployment_employeeId",
                schema: "HR",
                table: "PreviousEmployment",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualifications_employeeId",
                schema: "HR",
                table: "ProfessionalQualifications",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualifications_qualificationHeadId",
                schema: "HR",
                table: "ProfessionalQualifications",
                column: "qualificationHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualifications_resultId",
                schema: "HR",
                table: "ProfessionalQualifications",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_designationId",
                schema: "HR",
                table: "Promotion",
                column: "designationId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_employeeInfoid",
                schema: "HR",
                table: "Promotion",
                column: "employeeInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_salaryGradeId",
                schema: "HR",
                table: "Promotion",
                column: "salaryGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionLog_employeeId",
                schema: "HR",
                table: "PromotionLog",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionLog_payScaleId",
                schema: "HR",
                table: "PromotionLog",
                column: "payScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Publication_employeeId",
                schema: "HR",
                table: "Publication",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_employeeId",
                schema: "HR",
                table: "Reference",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RelDegreeSubject_degreeId",
                schema: "HR",
                table: "RelDegreeSubject",
                column: "degreeId");

            migrationBuilder.CreateIndex(
                name: "IX_RelDegreeSubject_subjectId",
                schema: "HR",
                table: "RelDegreeSubject",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftGroupDetail_shiftGroupMasterId",
                schema: "HR",
                table: "ShiftGroupDetail",
                column: "shiftGroupMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Spouse_employeeId",
                schema: "HR",
                table: "Spouse",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_employeeId",
                schema: "HR",
                table: "Supervisor",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_supervisorId",
                schema: "HR",
                table: "Supervisor",
                column: "supervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferLog_departmentId",
                schema: "HR",
                table: "TransferLog",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferLog_designationId",
                schema: "HR",
                table: "TransferLog",
                column: "designationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferLog_employeeId",
                schema: "HR",
                table: "TransferLog",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferLog_salaryGradeId",
                schema: "HR",
                table: "TransferLog",
                column: "salaryGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelInfo_countryId",
                schema: "HR",
                table: "TravelInfo",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelInfo_employeeId",
                schema: "HR",
                table: "TravelInfo",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelInfo_travelPurposeId",
                schema: "HR",
                table: "TravelInfo",
                column: "travelPurposeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompanyAddresses");

            migrationBuilder.DropTable(
                name: "CompanyGroups");

            migrationBuilder.DropTable(
                name: "AcrInfo",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "BankInfo",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Belongings",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Children",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "CourseTitle",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "DrivingLicense",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EducationalQualification",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmergencyContact",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeAward",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeContractInfo",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeLanguage",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeMembership",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeProjectActivity",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "FreedomFighter",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Holiday",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "LeaveLog",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "NomineeDetail",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "OtherActivity",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "OtherQualification",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "PassportDetails",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Photograph",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "PreviousEmployment",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "ProfessionalQualifications",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Promotion",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "PromotionLog",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Publication",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Reference",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Relation",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "ShiftGroupDetail",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Spouse",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Supervisor",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "TrainingCategory",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "TransferLog",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "TravelInfo",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "TravelVehicleType",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Year",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Thanas");

            migrationBuilder.DropTable(
                name: "RelDegreeSubject",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Membership",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "LeaveType",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Nominee",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "OtherQualificationHead",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "QualificationHead",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Result",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "ShiftGroupMaster",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Designation",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "SalaryGrade",
                schema: "Payroll");

            migrationBuilder.DropTable(
                name: "TravelPurpose",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Degree",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeInfo",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "LevelOfEducation",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "BranchUnit",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "EmployeeType",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Religion",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
