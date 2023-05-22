﻿// <auto-generated />
using System;
using DepremMisafiri.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepremMisafiri.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230521131548_DepremMisafiri_Migration_1")]
    partial class DepremMisafiri_Migration_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepremMisafiri.Models.Admin", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DepremMisafiri.Models.EarthquakeVictim", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EarthquakeVictims");
                });

            modelBuilder.Entity("DepremMisafiri.Models.Editor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editors");
                });

            modelBuilder.Entity("DepremMisafiri.Models.Host", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("DepremMisafiri.Models.House", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("HostId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxAvailableDays")
                        .HasColumnType("int");

                    b.Property<int?>("MaxGuestCount")
                        .HasColumnType("int");

                    b.Property<string>("SpecialConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("DepremMisafiri.Models.Request", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("EqVictimId")
                        .HasColumnType("int");

                    b.Property<int?>("GuestCount")
                        .HasColumnType("int");

                    b.Property<int?>("HouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EqVictimId");

                    b.HasIndex("HouseId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DepremMisafiri.Models.House", b =>
                {
                    b.HasOne("DepremMisafiri.Models.Host", "Host")
                        .WithMany()
                        .HasForeignKey("HostId");

                    b.Navigation("Host");
                });

            modelBuilder.Entity("DepremMisafiri.Models.Request", b =>
                {
                    b.HasOne("DepremMisafiri.Models.EarthquakeVictim", "EarthquakeVictim")
                        .WithMany()
                        .HasForeignKey("EqVictimId");

                    b.HasOne("DepremMisafiri.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId");

                    b.Navigation("EarthquakeVictim");

                    b.Navigation("House");
                });
#pragma warning restore 612, 618
        }
    }
}