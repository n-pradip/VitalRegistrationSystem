using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitalRegistrationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Births",
                columns: table => new
                {
                    BirthId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicantName = table.Column<string>(type: "text", nullable: false),
                    ApplicantAddress = table.Column<string>(type: "text", nullable: true),
                    ApplicantCitizenshipNum = table.Column<string>(type: "text", nullable: false),
                    GrandFathersName = table.Column<string>(type: "text", nullable: false),
                    FathersName = table.Column<string>(type: "text", nullable: false),
                    MothersName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChildName = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    ChildAddress = table.Column<string>(type: "text", nullable: false),
                    FatherCitizenshipNumber = table.Column<string>(type: "text", nullable: true),
                    MotherCitizenshipNumber = table.Column<string>(type: "text", nullable: true),
                    BirthRegistrationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Births", x => x.BirthId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Births");
        }
    }
}
