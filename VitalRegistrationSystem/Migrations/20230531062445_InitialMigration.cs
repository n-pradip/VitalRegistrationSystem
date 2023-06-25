using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitalRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Births",
                columns: table => new
                {
                    BirthId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantCitizenshipNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrandFathersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ChildAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Births", x => x.BirthId);
                });

            migrationBuilder.CreateTable(
                name: "Deaths",
                columns: table => new
                {
                    DeathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeceasedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrandfatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deaths", x => x.DeathId);
                });

            migrationBuilder.CreateTable(
                name: "Divorces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HusbandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HusbandAge = table.Column<int>(type: "int", nullable: false),
                    HusbandFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HusbandGrandFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HusbandAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HusbandCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeAge = table.Column<int>(type: "int", nullable: false),
                    WifeFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeGrandFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarriageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DivorceRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divorces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marriges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrideName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrideAge = table.Column<int>(type: "int", nullable: false),
                    BrideFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrideGrandFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrideAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrideCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BridegroomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BridegroomAge = table.Column<int>(type: "int", nullable: false),
                    BridegroomFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BridegroomGrandFather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BridegroomAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BridegroomCitizenshipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarriageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarriageRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marriges", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Births");

            migrationBuilder.DropTable(
                name: "Deaths");

            migrationBuilder.DropTable(
                name: "Divorces");

            migrationBuilder.DropTable(
                name: "Marriges");
        }
    }
}
