using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

/// <inheritdoc />
public partial class AddMoreActivities : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Cyclings",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                GoalId = table.Column<int>(type: "INTEGER", nullable: false),
                Distance = table.Column<double>(type: "REAL", nullable: false),
                TimeTaken = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                HeartRate = table.Column<double>(type: "REAL", nullable: false),
                Calories = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Cyclings", x => x.Id);
                table.ForeignKey(
                    name: "FK_Cyclings_Goals_GoalId",
                    column: x => x.GoalId,
                    principalTable: "Goals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Cyclings_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Runnings",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                GoalId = table.Column<int>(type: "INTEGER", nullable: false),
                Distance = table.Column<double>(type: "REAL", nullable: false),
                TimeTaken = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                HeartRate = table.Column<double>(type: "REAL", nullable: false),
                Calories = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Runnings", x => x.Id);
                table.ForeignKey(
                    name: "FK_Runnings_Goals_GoalId",
                    column: x => x.GoalId,
                    principalTable: "Goals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Runnings_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "WeightLiftings",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                GoalId = table.Column<int>(type: "INTEGER", nullable: false),
                Reps = table.Column<int>(type: "INTEGER", nullable: false),
                TimeTaken = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                Weight = table.Column<double>(type: "REAL", nullable: false),
                Calories = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_WeightLiftings", x => x.Id);
                table.ForeignKey(
                    name: "FK_WeightLiftings_Goals_GoalId",
                    column: x => x.GoalId,
                    principalTable: "Goals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_WeightLiftings_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Cyclings_GoalId",
            table: "Cyclings",
            column: "GoalId");

        migrationBuilder.CreateIndex(
            name: "IX_Cyclings_UserId",
            table: "Cyclings",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_Runnings_GoalId",
            table: "Runnings",
            column: "GoalId");

        migrationBuilder.CreateIndex(
            name: "IX_Runnings_UserId",
            table: "Runnings",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_WeightLiftings_GoalId",
            table: "WeightLiftings",
            column: "GoalId");

        migrationBuilder.CreateIndex(
            name: "IX_WeightLiftings_UserId",
            table: "WeightLiftings",
            column: "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Cyclings");

        migrationBuilder.DropTable(
            name: "Runnings");

        migrationBuilder.DropTable(
            name: "WeightLiftings");
    }
}
