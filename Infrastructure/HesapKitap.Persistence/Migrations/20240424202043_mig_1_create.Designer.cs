﻿// <auto-generated />
using System;
using HesapKitap.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HesapKitap.Persistence.Migrations
{
    [DbContext(typeof(MssqlDbContext))]
    [Migration("20240424202043_mig_1_create")]
    partial class mig_1_create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HesapKitap.Domain.Models.BaseModels.BaseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Account", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AccountTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.AccountType", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("AccountTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("UserId");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Category", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeExpenseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.IncomeExpense", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IncomeExpenseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tutar")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("UnderCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("IncomeExpenses");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.UnderCategory", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UndurCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CategoryId");

                    b.ToTable("UnderCategories");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.User", b =>
                {
                    b.HasBaseType("HesapKitap.Domain.Models.BaseModels.BaseModel");

                    b.Property<string>("EMailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Account", b =>
                {
                    b.HasOne("HesapKitap.Domain.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HesapKitap.Domain.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.AccountType", b =>
                {
                    b.HasOne("HesapKitap.Domain.Models.User", "User")
                        .WithMany("AccountTypes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Category", b =>
                {
                    b.HasOne("HesapKitap.Domain.Models.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.IncomeExpense", b =>
                {
                    b.HasOne("HesapKitap.Domain.Models.Account", "Account")
                        .WithMany("IncomeExpenses")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HesapKitap.Domain.Models.Category", "Category")
                        .WithMany("IncomeExpenses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HesapKitap.Domain.Models.User", "User")
                        .WithMany("IncomeExpenses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.UnderCategory", b =>
                {
                    b.HasOne("HesapKitap.Domain.Models.Category", "Category")
                        .WithMany("UnderCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Account", b =>
                {
                    b.Navigation("IncomeExpenses");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.Category", b =>
                {
                    b.Navigation("IncomeExpenses");

                    b.Navigation("UnderCategories");
                });

            modelBuilder.Entity("HesapKitap.Domain.Models.User", b =>
                {
                    b.Navigation("AccountTypes");

                    b.Navigation("Accounts");

                    b.Navigation("Categories");

                    b.Navigation("IncomeExpenses");
                });
#pragma warning restore 612, 618
        }
    }
}
