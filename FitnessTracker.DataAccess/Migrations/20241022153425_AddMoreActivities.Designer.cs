﻿// <auto-generated />
using FitnessTracker.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

[DbContext(typeof(FitnessContext))]
[Migration("20241022153425_AddMoreActivities")]
partial class AddMoreActivities
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Cycling", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("Calories")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<double>("Distance")
                    .HasColumnType("REAL");

                b.Property<int>("GoalId")
                    .HasColumnType("INTEGER");

                b.Property<double>("HeartRate")
                    .HasColumnType("REAL");

                b.Property<TimeSpan>("TimeTaken")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("GoalId");

                b.HasIndex("UserId");

                b.ToTable("Cyclings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Running", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("Calories")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<double>("Distance")
                    .HasColumnType("REAL");

                b.Property<int>("GoalId")
                    .HasColumnType("INTEGER");

                b.Property<double>("HeartRate")
                    .HasColumnType("REAL");

                b.Property<TimeSpan>("TimeTaken")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("GoalId");

                b.HasIndex("UserId");

                b.ToTable("Runnings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Swimming", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("Calories")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("GoalId")
                    .HasColumnType("INTEGER");

                b.Property<double>("HeartRate")
                    .HasColumnType("REAL");

                b.Property<int>("Laps")
                    .HasColumnType("INTEGER");

                b.Property<TimeSpan>("TimeTaken")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("GoalId");

                b.HasIndex("UserId");

                b.ToTable("Swimmings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Walking", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("Calories")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<double>("Distance")
                    .HasColumnType("REAL");

                b.Property<int>("GoalId")
                    .HasColumnType("INTEGER");

                b.Property<int>("Steps")
                    .HasColumnType("INTEGER");

                b.Property<TimeSpan>("TimeTaken")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("GoalId");

                b.HasIndex("UserId");

                b.ToTable("Walkings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.WeightLifting", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("Calories")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("GoalId")
                    .HasColumnType("INTEGER");

                b.Property<int>("Reps")
                    .HasColumnType("INTEGER");

                b.Property<TimeSpan>("TimeTaken")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.Property<double>("Weight")
                    .HasColumnType("REAL");

                b.HasKey("Id");

                b.HasIndex("GoalId");

                b.HasIndex("UserId");

                b.ToTable("WeightLiftings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.ApplicationUser", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<bool>("IsLocked")
                    .HasColumnType("INTEGER");

                b.Property<int>("LoginAttempts")
                    .HasColumnType("INTEGER");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<string>("Username")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Users");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Goal", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<double>("CaloriesTarget")
                    .HasColumnType("REAL");

                b.Property<DateTime>("CreatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<double>("Progress")
                    .HasColumnType("REAL");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<DateTime>("UpdatedAtUtc")
                    .HasColumnType("TEXT");

                b.Property<int>("UserId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("Goals");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Cycling", b =>
            {
                b.HasOne("FitnessTracker.Domain.Goal", "Goal")
                    .WithMany("Cyclings")
                    .HasForeignKey("GoalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("Cyclings")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Goal");

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Running", b =>
            {
                b.HasOne("FitnessTracker.Domain.Goal", "Goal")
                    .WithMany("Runnings")
                    .HasForeignKey("GoalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("Runnings")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Goal");

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Swimming", b =>
            {
                b.HasOne("FitnessTracker.Domain.Goal", "Goal")
                    .WithMany("Swimmings")
                    .HasForeignKey("GoalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("Swimmings")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Goal");

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.Walking", b =>
            {
                b.HasOne("FitnessTracker.Domain.Goal", "Goal")
                    .WithMany("Walkings")
                    .HasForeignKey("GoalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("Walkings")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Goal");

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Activities.WeightLifting", b =>
            {
                b.HasOne("FitnessTracker.Domain.Goal", "Goal")
                    .WithMany("WeightLiftings")
                    .HasForeignKey("GoalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("WeightLiftings")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Goal");

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Goal", b =>
            {
                b.HasOne("FitnessTracker.Domain.ApplicationUser", "User")
                    .WithMany("Goals")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

        modelBuilder.Entity("FitnessTracker.Domain.ApplicationUser", b =>
            {
                b.Navigation("Cyclings");

                b.Navigation("Goals");

                b.Navigation("Runnings");

                b.Navigation("Swimmings");

                b.Navigation("Walkings");

                b.Navigation("WeightLiftings");
            });

        modelBuilder.Entity("FitnessTracker.Domain.Goal", b =>
            {
                b.Navigation("Cyclings");

                b.Navigation("Runnings");

                b.Navigation("Swimmings");

                b.Navigation("Walkings");

                b.Navigation("WeightLiftings");
            });
#pragma warning restore 612, 618
    }
}