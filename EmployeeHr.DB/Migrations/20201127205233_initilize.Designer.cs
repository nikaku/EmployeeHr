﻿// <auto-generated />
using System;
using EmployeeHr.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeHr.DB.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201127205233_initilize")]
    partial class initilize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EmployeeHr.BL.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SettlementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SettlementId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForeignName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegalFrom")
                        .HasColumnType("int");

                    b.Property<string>("LocalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OutpatientCases")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SendSms")
                        .HasColumnType("bit");

                    b.Property<bool>("StationalCases")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fund")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.DepartmentsAndBranches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentsAndBranches");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Municipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.PositionsAndDepartments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsAndBranchesId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("StaffNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DepartmentsAndBranchesId");

                    b.HasIndex("PositionId");

                    b.ToTable("PositionsAndDepartments");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Settlement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MunicipalityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("Settlements");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Address", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Settlement", "Settlement")
                        .WithMany()
                        .HasForeignKey("SettlementId");

                    b.Navigation("Settlement");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.BankAccount", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Branch", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.DepartmentsAndBranches", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Branch", "Branch")
                        .WithMany("DepartmentsAndBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeHr.BL.Entities.Department", "Department")
                        .WithMany("DepartmentsAndBranches")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Municipality", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Region", null)
                        .WithMany("Municipalities")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.PositionsAndDepartments", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Department", null)
                        .WithMany("PositionsAndDepartments")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("EmployeeHr.BL.Entities.DepartmentsAndBranches", "DepartmentsAndBranches")
                        .WithMany()
                        .HasForeignKey("DepartmentsAndBranchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeHr.BL.Entities.Position", "Position")
                        .WithMany("PositionsAndDepartments")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentsAndBranches");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Settlement", b =>
                {
                    b.HasOne("EmployeeHr.BL.Entities.Municipality", null)
                        .WithMany("Settlements")
                        .HasForeignKey("MunicipalityId");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Branch", b =>
                {
                    b.Navigation("DepartmentsAndBranches");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Department", b =>
                {
                    b.Navigation("DepartmentsAndBranches");

                    b.Navigation("PositionsAndDepartments");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Municipality", b =>
                {
                    b.Navigation("Settlements");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Position", b =>
                {
                    b.Navigation("PositionsAndDepartments");
                });

            modelBuilder.Entity("EmployeeHr.BL.Entities.Region", b =>
                {
                    b.Navigation("Municipalities");
                });
#pragma warning restore 612, 618
        }
    }
}
