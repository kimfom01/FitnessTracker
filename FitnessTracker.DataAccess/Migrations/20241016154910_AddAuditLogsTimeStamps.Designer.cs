﻿// <auto-generated />
using FitnessTracker.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

[DbContext(typeof(FitnessContext))]
[Migration("20241016154910_AddAuditLogsTimeStamps")]
partial class AddAuditLogsTimeStamps
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

        modelBuilder.Entity("FitnessTracker.DataAccess.Entities.ApplicationUser", b =>
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
#pragma warning restore 612, 618
    }
}
