﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120161335_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("WebApplication1.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PredictedEnergy")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("WebApplication1.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TaskBaseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskBaseId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DayId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Energy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Enjoyment")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastCompletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("TimeOfDay")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeSpan")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tolerance")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("TaskBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TaskBase");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AverageEnergy")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication1.Models.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskDaily", b =>
                {
                    b.HasBaseType("WebApplication1.Models.TaskBase");

                    b.Property<bool>("Skippable")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("TaskDaily");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Example Description",
                            Energy = 5,
                            Enjoyment = 5,
                            LastCompletedDate = new DateTime(2023, 11, 20, 11, 13, 35, 400, DateTimeKind.Local).AddTicks(6211),
                            Name = "Example Daily Task",
                            Priority = 1,
                            TimeOfDay = new TimeOnly(8, 0, 0),
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0),
                            Tolerance = 5,
                            Skippable = true
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.TaskPeriodic", b =>
                {
                    b.HasBaseType("WebApplication1.Models.TaskBase");

                    b.Property<int>("Period")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Unit")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("TaskPeriodic");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Description = "Example Description",
                            Energy = 5,
                            Enjoyment = 5,
                            LastCompletedDate = new DateTime(2023, 11, 20, 11, 13, 35, 413, DateTimeKind.Local).AddTicks(9396),
                            Name = "Example Periodic Task",
                            Priority = 1,
                            TimeOfDay = new TimeOnly(8, 0, 0),
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0),
                            Tolerance = 5,
                            Period = 1,
                            Unit = 3
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.TaskTransient", b =>
                {
                    b.HasBaseType("WebApplication1.Models.TaskBase");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("TaskTransient");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Description = "Example Description",
                            Energy = 5,
                            Enjoyment = 5,
                            LastCompletedDate = new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(19),
                            Name = "Example Transient Task",
                            Priority = 1,
                            TimeOfDay = new TimeOnly(8, 0, 0),
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0),
                            Tolerance = 5,
                            DueDate = new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(40)
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.TaskTransition", b =>
                {
                    b.HasBaseType("WebApplication1.Models.TaskBase");

                    b.HasDiscriminator().HasValue("TaskTransition");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Description = "Example Description",
                            Energy = 5,
                            Enjoyment = 5,
                            LastCompletedDate = new DateTime(2023, 11, 20, 11, 13, 35, 414, DateTimeKind.Local).AddTicks(435),
                            Name = "Example Periodic Task",
                            Priority = 1,
                            TimeOfDay = new TimeOnly(8, 0, 0),
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0),
                            Tolerance = 5
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Step", b =>
                {
                    b.HasOne("WebApplication1.Models.TaskBase", null)
                        .WithMany("Steps")
                        .HasForeignKey("TaskBaseId");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskBase", b =>
                {
                    b.HasOne("WebApplication1.Models.Day", null)
                        .WithMany("Tasks")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("WebApplication1.Models.Day", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskBase", b =>
                {
                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
