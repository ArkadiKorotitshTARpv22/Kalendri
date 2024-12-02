﻿// <auto-generated />
using System;
using KalenderApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KalendriApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241030010903_InitialMigration2")]
    partial class InitialMigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KalenderApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#FF0000",
                            Name = "Работа"
                        },
                        new
                        {
                            Id = 2,
                            Color = "#00FF00",
                            Name = "Личное"
                        },
                        new
                        {
                            Id = 3,
                            Color = "#0000FF",
                            Name = "Семья"
                        });
                });

            modelBuilder.Entity("KalenderApp.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recurrence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reminder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Обсуждение проекта",
                            EndDateTime = new DateTime(2024, 10, 31, 5, 9, 2, 70, DateTimeKind.Local).AddTicks(5198),
                            Recurrence = "none",
                            Reminder = "email",
                            StartDateTime = new DateTime(2024, 10, 31, 3, 9, 2, 70, DateTimeKind.Local).AddTicks(4775),
                            Timezone = "Europe/Tallinn",
                            Title = "Встреча с командой",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "День рождения друга",
                            EndDateTime = new DateTime(2024, 11, 1, 6, 9, 2, 70, DateTimeKind.Local).AddTicks(5249),
                            Recurrence = "yearly",
                            Reminder = "notification",
                            StartDateTime = new DateTime(2024, 11, 1, 3, 9, 2, 70, DateTimeKind.Local).AddTicks(5246),
                            Timezone = "Europe/Tallinn",
                            Title = "День рождения",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("KalenderApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@example.com",
                            Name = "Admin",
                            Password = "$2a$11$fVX.lzIZUK63ay0mARZ1vOEgh.mfBVEDHivuboiNRoULrzqN2JL/2",
                            Timezone = "Europe/Tallinn"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@example.com",
                            Name = "User",
                            Password = "$2a$11$QFzbINr4Xad1UpGO/wQJT.yOd6x9gZ1w7Zspyk4IRAGXtQGd2CfWy",
                            Timezone = "Europe/Tallinn"
                        });
                });

            modelBuilder.Entity("KalenderApp.Models.Event", b =>
                {
                    b.HasOne("KalenderApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KalenderApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
