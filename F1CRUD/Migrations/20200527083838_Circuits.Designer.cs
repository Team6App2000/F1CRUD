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
    [Migration("20200527083838_Circuits")]
    partial class Circuits
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
#pragma warning restore 612, 618
        }
    }
}
