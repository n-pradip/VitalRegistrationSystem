﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VitalRegistrationSystem.Data;

#nullable disable

namespace VitalRegistrationSystem.Migrations
{
    [DbContext(typeof(VRSDbContext))]
    [Migration("20230531062445_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VitalRegistrationSystem.Models.BirthModel", b =>
                {
                    b.Property<Guid>("BirthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicantAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantCitizenshipNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChildAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherCitizenshipNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("GrandFathersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherCitizenshipNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BirthId");

                    b.ToTable("Births");
                });

            modelBuilder.Entity("VitalRegistrationSystem.Models.DeathModel", b =>
                {
                    b.Property<Guid>("DeathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantCitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeathRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeceasedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrandfatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeathId");

                    b.ToTable("Deaths");
                });

            modelBuilder.Entity("VitalRegistrationSystem.Models.DivorceModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DivorceRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HusbandAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HusbandAge")
                        .HasColumnType("int");

                    b.Property<string>("HusbandCitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HusbandFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HusbandGrandFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HusbandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MarriageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WifeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WifeAge")
                        .HasColumnType("int");

                    b.Property<string>("WifeCitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WifeFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WifeGrandFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WifeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Divorces");
                });

            modelBuilder.Entity("VitalRegistrationSystem.Models.MarrigeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrideAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrideAge")
                        .HasColumnType("int");

                    b.Property<string>("BrideCitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrideFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrideGrandFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrideName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BridegroomAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BridegroomAge")
                        .HasColumnType("int");

                    b.Property<string>("BridegroomCitizenshipNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BridegroomFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BridegroomGrandFather")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BridegroomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MarriageDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MarriageRegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Marriges");
                });
#pragma warning restore 612, 618
        }
    }
}