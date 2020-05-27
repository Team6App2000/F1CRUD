﻿// <auto-generated />
using F1CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F1CRUD.Migrations
{
    [DbContext(typeof(F1CRUDContext))]
    [Migration("20200527085426_Results")]
    partial class Results
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("F1CRUD.F1.Circuits", b =>
                {
                    b.Property<string>("circuitId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("circuitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("circuitId");

                    b.ToTable("Circuits");
                });

            modelBuilder.Entity("F1CRUD.F1.Constructors", b =>
                {
                    b.Property<string>("constructorsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("constructorsId");

                    b.ToTable("Constructors");
                });

            modelBuilder.Entity("F1CRUD.F1.Drivers", b =>
                {
                    b.Property<string>("driverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("dateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("familyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("givenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("driverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("F1CRUD.F1.Races", b =>
                {
                    b.Property<string>("raceName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("circuitId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("round")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("season")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("raceName");

                    b.HasIndex("circuitId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("F1CRUD.F1.Results", b =>
                {
                    b.Property<int>("resultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("circuitId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("constructorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("driverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("grid")
                        .HasColumnType("int");

                    b.Property<int>("laps")
                        .HasColumnType("int");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("points")
                        .HasColumnType("int");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.Property<string>("raceName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("resultId");

                    b.HasIndex("circuitId");

                    b.HasIndex("constructorId");

                    b.HasIndex("driverId");

                    b.HasIndex("raceName");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("F1CRUD.F1.Races", b =>
                {
                    b.HasOne("F1CRUD.F1.Circuits", "circuits")
                        .WithMany()
                        .HasForeignKey("circuitId");
                });

            modelBuilder.Entity("F1CRUD.F1.Results", b =>
                {
                    b.HasOne("F1CRUD.F1.Circuits", "circuits")
                        .WithMany()
                        .HasForeignKey("circuitId");

                    b.HasOne("F1CRUD.F1.Constructors", "Constructors")
                        .WithMany()
                        .HasForeignKey("constructorId");

                    b.HasOne("F1CRUD.F1.Drivers", "Drivers")
                        .WithMany()
                        .HasForeignKey("driverId");

                    b.HasOne("F1CRUD.F1.Races", "Races")
                        .WithMany()
                        .HasForeignKey("raceName");
                });
#pragma warning restore 612, 618
        }
    }
}