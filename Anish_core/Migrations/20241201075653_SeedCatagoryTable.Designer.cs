﻿// <auto-generated />
using Anish_core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Anish_core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241201075653_SeedCatagoryTable")]
    partial class SeedCatagoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Anish_core.Models.Catagory", b =>
                {
                    b.Property<int>("Catagory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Catagory_Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Catagory_Id");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            Catagory_Id = 1,
                            DisplayOrder = 1,
                            Name = "Anish"
                        },
                        new
                        {
                            Catagory_Id = 2,
                            DisplayOrder = 2,
                            Name = "Uttara"
                        },
                        new
                        {
                            Catagory_Id = 3,
                            DisplayOrder = 3,
                            Name = "Mau"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}