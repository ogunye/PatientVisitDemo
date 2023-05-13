using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientVisitDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Address_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line_1_number_Building = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Street_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Area_Locality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Address_Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Visit_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Visit_Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Consultant_Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Medical_Centre_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Doctor_Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Doctor_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Centers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Centers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Procedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Procedure_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Procedure_Price = table.Column<double>(type: "float", nullable: true),
                    Procedure_Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Procedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medication_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Medication_Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Medication_Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Registred = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visit_Medications",
                columns: table => new
                {
                    Visit_Id = table.Column<int>(type: "int", nullable: false),
                    Medication_Id = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Derived_Cost_Medication = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit_Medications", x => new { x.Visit_Id, x.Medication_Id });
                });

            migrationBuilder.CreateTable(
                name: "Visit_Procedures",
                columns: table => new
                {
                    Visit_Id = table.Column<int>(type: "int", nullable: false),
                    Medical_Procedure_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Derived_Cost_Procedure = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit_Procedures", x => new { x.Visit_Id, x.Medical_Procedure_Id });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Medical_Centers");

            migrationBuilder.DropTable(
                name: "Medical_Procedures");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Visit_Medications");

            migrationBuilder.DropTable(
                name: "Visit_Procedures");
        }
    }
}
