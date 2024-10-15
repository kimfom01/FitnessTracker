using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

/// <inheritdoc />
public partial class AddLoginAttemptsAndIsLocked : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsLocked",
            table: "Users",
            type: "INTEGER",
            nullable: false,
            defaultValue: false);

        migrationBuilder.AddColumn<int>(
            name: "LoginAttempts",
            table: "Users",
            type: "INTEGER",
            nullable: false,
            defaultValue: 3);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "IsLocked",
            table: "Users");

        migrationBuilder.DropColumn(
            name: "LoginAttempts",
            table: "Users");
    }
}
