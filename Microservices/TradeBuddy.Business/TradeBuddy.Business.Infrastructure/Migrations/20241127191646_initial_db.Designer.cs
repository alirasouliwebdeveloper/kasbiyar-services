﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradeBuddy.Business.Infrastructure.Context;

#nullable disable

namespace TradeBuddy.Business.Infrastructure.Migrations
{
    [DbContext(typeof(BusinessDbContext))]
    [Migration("20241127191646_initial_db")]
    partial class initial_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BusinessHoursBusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BusinessHoursBusinessId");

                    b.ToTable("TimeSlots");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AverageRating")
                        .HasColumnType("float");

                    b.Property<Guid>("BusinessCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalReviews")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCategoryId");

                    b.HasIndex("BusinessTypeId");

                    b.HasIndex("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BusinessCategories");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessHours", b =>
                {
                    b.Property<Guid>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BusinessId");

                    b.HasIndex("BusinessId1");

                    b.ToTable("BusinessHours");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BusinessType");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EndHour")
                        .HasColumnType("int");

                    b.Property<int>("EndMinute")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StartHour")
                        .HasColumnType("int");

                    b.Property<int>("StartMinute")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.HasIndex("BusinessId1");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.WorkingDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId", "Date")
                        .IsUnique();

                    b.ToTable("WorkingDays");
                });

            modelBuilder.Entity("TimeSlot", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.BusinessHours", null)
                        .WithMany("TimeSlots")
                        .HasForeignKey("BusinessHoursBusinessId");

                    b.OwnsOne("TradeBuddy.Business.Domain.ValueObjects.Time", "EndTime", b1 =>
                        {
                            b1.Property<Guid>("TimeSlotId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.HasKey("TimeSlotId");

                            b1.ToTable("TimeSlots");

                            b1.WithOwner()
                                .HasForeignKey("TimeSlotId");
                        });

                    b.OwnsOne("TradeBuddy.Business.Domain.ValueObjects.Time", "StartTime", b1 =>
                        {
                            b1.Property<Guid>("TimeSlotId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Hour")
                                .HasColumnType("int");

                            b1.Property<int>("Minute")
                                .HasColumnType("int");

                            b1.HasKey("TimeSlotId");

                            b1.ToTable("TimeSlots");

                            b1.WithOwner()
                                .HasForeignKey("TimeSlotId");
                        });

                    b.Navigation("EndTime")
                        .IsRequired();

                    b.Navigation("StartTime")
                        .IsRequired();
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.Business", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.BusinessCategory", "BusinessCategory")
                        .WithMany("Businesses")
                        .HasForeignKey("BusinessCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TradeBuddy.Business.Domain.Entities.BusinessType", "BusinessType")
                        .WithMany()
                        .HasForeignKey("BusinessTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TradeBuddy.Business.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradeBuddy.Business.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BusinessCategory");

                    b.Navigation("BusinessType");

                    b.Navigation("City");

                    b.Navigation("State");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessHours", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.Business", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.City", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.Service", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.Business", null)
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TradeBuddy.Business.Domain.Entities.Business", "Business")
                        .WithMany("Services")
                        .HasForeignKey("BusinessId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("TradeBuddy.Business.Domain.ValueObjects.ServiceLocationType", "ServiceLocationTypes", b1 =>
                        {
                            b1.Property<Guid>("ServiceId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("LocationType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ServiceId", "Id");

                            b1.ToTable("ServiceLocationType");

                            b1.WithOwner()
                                .HasForeignKey("ServiceId");
                        });

                    b.Navigation("Business");

                    b.Navigation("ServiceLocationTypes");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.WorkingDay", b =>
                {
                    b.HasOne("TradeBuddy.Business.Domain.Entities.BusinessHours", null)
                        .WithMany("WorkingDays")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TradeBuddy.Business.Domain.Entities.Business", null)
                        .WithMany("WorkingDays")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.Business", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("WorkingDays");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessCategory", b =>
                {
                    b.Navigation("Businesses");
                });

            modelBuilder.Entity("TradeBuddy.Business.Domain.Entities.BusinessHours", b =>
                {
                    b.Navigation("TimeSlots");

                    b.Navigation("WorkingDays");
                });
#pragma warning restore 612, 618
        }
    }
}
