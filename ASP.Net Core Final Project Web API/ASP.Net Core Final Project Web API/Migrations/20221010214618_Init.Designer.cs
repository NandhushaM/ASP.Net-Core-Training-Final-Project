﻿// <auto-generated />
using System;
using ASP.Net_Core_Final_Project_Web_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.Net_Core_Final_Project_Web_API.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20221010214618_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("LockStatus")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("lockstatus");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("manager");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("name");

                    b.Property<string>("Wfm_Manager")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("wfm_manager");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Email = "nandhu@gmail.com",
                            Experience = 2,
                            LockStatus = "not_requested",
                            Manager = "Monika",
                            Name = "nandhu",
                            Wfm_Manager = "Sabitha"
                        });
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.SkillMap", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    b.Property<int>("SkillId")
                        .HasColumnType("int")
                        .HasColumnName("skillId");

                    b.HasKey("EmployeeId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillsMap");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("skillId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "javascript"
                        });
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.SoftLock", b =>
                {
                    b.Property<int>("LockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("lockId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LockId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("manager");

                    b.Property<string>("ManagerStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("managerstatus");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("reqdate");

                    b.Property<string>("RequestMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("requestmessage");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("LockId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SoftLock");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.SkillMap", b =>
                {
                    b.HasOne("ASP.Net_Core_Final_Project_Web_API.Models.Employees", "Employees")
                        .WithMany("SkillMaps")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.Net_Core_Final_Project_Web_API.Models.Skills", "Skills")
                        .WithMany("SkillMaps")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.SoftLock", b =>
                {
                    b.HasOne("ASP.Net_Core_Final_Project_Web_API.Models.Employees", "Employees")
                        .WithMany("SoftLocks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.Employees", b =>
                {
                    b.Navigation("SkillMaps");

                    b.Navigation("SoftLocks");
                });

            modelBuilder.Entity("ASP.Net_Core_Final_Project_Web_API.Models.Skills", b =>
                {
                    b.Navigation("SkillMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
