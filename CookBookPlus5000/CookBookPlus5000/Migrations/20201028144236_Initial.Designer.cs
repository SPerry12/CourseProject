﻿// <auto-generated />
using CookBookPlus5000.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CookBookPlus5000.Migrations
{
    [DbContext(typeof(CookBookPlus5000Context))]
    [Migration("20201028144236_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookBookPlus5000.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Carbs")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Fat")
                        .HasColumnType("int");

                    b.Property<int>("Protein")
                        .HasColumnType("int");

                    b.Property<string>("RecipeDirections")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
