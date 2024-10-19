using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

/// <inheritdoc />
public partial class AddTitleToGoals : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Title",
            table: "Goals",
            type: "TEXT",
            nullable: false,
            defaultValue: "");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Title",
            table: "Goals");
    }
}
