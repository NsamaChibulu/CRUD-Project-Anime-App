﻿// <auto-generated />
using System;
using AnimeProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimeProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimeProject.Models.Anime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Adaptation")
                        .HasColumnType("int");

                    b.Property<string>("AiringDay")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<int?>("MonthID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.HasIndex("MonthID");

                    b.ToTable("Animes");
                });

            modelBuilder.Entity("AnimeProject.Models.Month", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("AnimeProject.Models.Anime", b =>
                {
                    b.HasOne("AnimeProject.Models.Month", "Month")
                        .WithMany("Animes")
                        .HasForeignKey("MonthID");

                    b.Navigation("Month");
                });

            modelBuilder.Entity("AnimeProject.Models.Month", b =>
                {
                    b.Navigation("Animes");
                });
#pragma warning restore 612, 618
        }
    }
}
