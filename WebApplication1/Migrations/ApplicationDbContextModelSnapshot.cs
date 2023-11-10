﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("WebApplication1.Models.CostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Energy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Enjoyment")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("TimeSpan")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Costs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Energy = 6,
                            Enjoyment = 9,
                            TimeSpan = new TimeSpan(0, 0, 15, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Energy = 10,
                            Enjoyment = 8,
                            TimeSpan = new TimeSpan(0, 0, 15, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Energy = 1,
                            Enjoyment = 9,
                            TimeSpan = new TimeSpan(0, 0, 50, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Energy = 1,
                            Enjoyment = 8,
                            TimeSpan = new TimeSpan(0, 0, 15, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Energy = 2,
                            Enjoyment = 2,
                            TimeSpan = new TimeSpan(0, 0, 45, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Energy = 8,
                            Enjoyment = 8,
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Energy = 4,
                            Enjoyment = 8,
                            TimeSpan = new TimeSpan(0, 0, 50, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Energy = 6,
                            Enjoyment = 6,
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Energy = 10,
                            Enjoyment = 6,
                            TimeSpan = new TimeSpan(0, 1, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Energy = 3,
                            Enjoyment = 2,
                            TimeSpan = new TimeSpan(0, 0, 25, 0, 0)
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.StepModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TaskModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskModelId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CostModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastCompletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("TimeOfDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tolerance")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CostModelId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CostModelId = 1,
                            Description = "Example Description",
                            LastCompletedDate = new DateTime(2023, 11, 10, 15, 23, 59, 1, DateTimeKind.Local).AddTicks(2493),
                            Name = "Example Task",
                            Priority = 7,
                            TimeOfDay = new TimeOnly(8, 0, 0),
                            Tolerance = 5
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.StepModel", b =>
                {
                    b.HasOne("WebApplication1.Models.TaskModel", null)
                        .WithMany("Steps")
                        .HasForeignKey("TaskModelId");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskModel", b =>
                {
                    b.HasOne("WebApplication1.Models.CostModel", "Cost")
                        .WithMany()
                        .HasForeignKey("CostModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cost");
                });

            modelBuilder.Entity("WebApplication1.Models.TaskModel", b =>
                {
                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
